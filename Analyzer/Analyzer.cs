﻿using Analyzer.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Analyzer : IAnalyzer
    {

        Analyzer()
        {

        }

        public void Configure(IDictionary<int, bool> TeacherOptions, bool TeacherFlag)
        {

        }

        public void LoadDLLFile(List<string> PathOfDLLFilesOfStudent, string? PathOfDLLFileOfTeacher)
        {


        }
        public Tuple<IDictionary<string, string>, int> GetAnalysis()
        {

            return null;
        }

        public void GetRelationshipGraph()
        {

            MainPipeline mp = new MainPipeline();

        }

    }
}