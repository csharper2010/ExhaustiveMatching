using ExhaustiveMatching.Analyzer.Testing.Verifiers;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ExhaustiveMatching.Analyzer.Tests
{
    public class ExhaustiveMatchAnalyzerTests : DiagnosticVerifier
    {
        public ExhaustiveMatchAnalyzerTests()
        {
            // Set the culture to English for all tests
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }

        [Fact]
        public async Task EmptyFileReportsNoDiagnostics()
        {
            const string test = @"";

            await VerifyCSharpDiagnosticsAsync(test);
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
            => new ExhaustiveMatchAnalyzer();
    }
}
