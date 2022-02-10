using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlMutatorCore
{
    public class SqlMutatorMainRunner
    {
        public string OriginalFilePath { get; set; }
        public string OriginalContent { get; }
        public string MutatedContent { get; set; }

        private int filesCounter = 0;
        public enum MutationType
        {
            SelectToSelectDistinct,
            SelectDistinctToSelect,
            OrderByToOrderByDesc,
            OrderByDescToOrderBy,
            UnionToUnionAll,
            UnionAllToUnion,
            RelationalOperator,
            LogicalOperator,
            NullOperator
        }

        public SqlMutatorMainRunner(string originalFilePath, string originalContent)
        {
            OriginalFilePath = originalFilePath;
            OriginalContent = originalContent;
        }

        public void StartMutation(MutationType mutationType)
        {
            // 1. Define the Syntax Tree for Original Code, and get its root.
            SyntaxTree objTree = CSharpSyntaxTree.ParseText(OriginalContent);
            var objOriginlRoot = objTree.GetRoot();

            // 2.a. Define the Rewriter Object...
            CSharpSyntaxRewriter objRewriterObject = null;

            // 2.b. Call the proper constructor based on Mutation Type that is passed to this function.
            switch (mutationType)
            {
                case MutationType.SelectToSelectDistinct:
                    objRewriterObject = new SelectToSelectDistinct();
                    break;

                case MutationType.SelectDistinctToSelect:
                    objRewriterObject = new SelectDistinctToSelect();
                    break;

                default:
                    throw new NotImplementedException(mutationType.ToString());
            }

            // 3. Do Mutation if that is needed.
            var objMutatedRoot = objRewriterObject.Visit(objOriginlRoot);

            // 4. Writing Original and Mutated Codes
            string sOriginalRootString = objOriginlRoot.ToFullString();
            string sMutatedRootString = objMutatedRoot.ToFullString();

            // 5. Checking if Original and Mutated Codes are the same, no need to rewrite them to files
            if (!sOriginalRootString.Equals(sMutatedRootString))
            {
                FileInfo file = new FileInfo(OriginalFilePath);

                // 6. Preparing Paths and filenames
                string sOriginalFileDirectory = file.DirectoryName;
                string sOutputFileDirectory = sOriginalFileDirectory + "\\Output-" + file.Name;

                string sOriginalFileNewPath = sOutputFileDirectory + "\\" + file.Name;

                // Checking if Output folder exists or not to create it.
                if (!Directory.Exists(sOutputFileDirectory))
                    Directory.CreateDirectory(sOutputFileDirectory);

                // Making sure that Original file was written before or not
                if (!File.Exists(sOriginalFileNewPath))
                {
                    StreamWriter writer = new StreamWriter(sOriginalFileNewPath);
                    writer.Write(sOriginalRootString);

                    writer.Close();
                }

                // Creating Mutated file's name, and making sure we do NOT replace any existing file in output folder.
                string sMutatedFilePath = sOutputFileDirectory + "\\" + filesCounter++ + "-" + file.Name;

                while (File.Exists(sMutatedFilePath))
                    sMutatedFilePath = sOutputFileDirectory + "\\" + filesCounter++ + "-" + file.Name;

                // Defining writing function in a separate scope
                {
                    StreamWriter writer = new StreamWriter(sMutatedFilePath);
                    writer.Write(sMutatedRootString);

                    writer.Close();
                }
            }
        }
    }
}
