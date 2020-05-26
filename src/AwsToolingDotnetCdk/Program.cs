using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwsToolingDotnetCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new AwsToolingDotnetCdkStack(app, "AwsToolingDotnetCdkStack");
            app.Synth();
        }
    }
}
