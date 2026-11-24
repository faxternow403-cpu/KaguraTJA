using OpenTaiko;
using Xunit;

namespace OpenTaikoTests;

public class OpenTaikoChartAccessTests {
	[Fact]
	public void GetTJA_ReturnsNullForInvalidPlayerIndexes() {
		Assert.Null(OpenTaiko.OpenTaiko.GetTJA(-1));
		Assert.Null(OpenTaiko.OpenTaiko.GetTJA(OpenTaiko.OpenTaiko.MAX_PLAYERS));
	}

	[Fact]
	public void SetTJA_IgnoresInvalidPlayerIndexes() {
		OpenTaiko.OpenTaiko.SetTJA(OpenTaiko.OpenTaiko.MAX_PLAYERS, null);
		OpenTaiko.OpenTaiko.SetTJA(-1, null);
	}

	[Fact]
	public void TJAs_ReturnsAnIndependentArraySnapshot() {
		Assert.NotSame(OpenTaiko.OpenTaiko.TJAs, OpenTaiko.OpenTaiko.TJAs);
		Assert.Equal(OpenTaiko.OpenTaiko.MAX_PLAYERS, OpenTaiko.OpenTaiko.TJAs.Length);
	}
}
