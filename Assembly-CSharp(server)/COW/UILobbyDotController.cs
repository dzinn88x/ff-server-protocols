using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019F5 RID: 6645
	[Token(Token = "0x20019F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F752C", Offset = "0x10F752C")]
	internal class UILobbyDotController : UIBaseController
	{
		// Token: 0x06008980 RID: 35200 RVA: 0x00024EE8 File Offset: 0x000230E8
		[Token(Token = "0x6008980")]
		[Address(RVA = "0x152E068", Offset = "0x152E068", VA = "0x7BBBD2E068")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008981")]
		[Address(RVA = "0x152E0B8", Offset = "0x152E0B8", VA = "0x7BBBD2E0B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008982")]
		[Address(RVA = "0x152E174", Offset = "0x152E174", VA = "0x7BBBD2E174")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008983")]
		[Address(RVA = "0x152E1FC", Offset = "0x152E1FC", VA = "0x7BBBD2E1FC")]
		public void SetWidth(int width)
		{
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008984")]
		[Address(RVA = "0x152E2DC", Offset = "0x152E2DC", VA = "0x7BBBD2E2DC")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008985")]
		[Address(RVA = "0x152E3BC", Offset = "0x152E3BC", VA = "0x7BBBD2E3BC")]
		public UILobbyDotController()
		{
		}

		// Token: 0x04009797 RID: 38807
		[Token(Token = "0x4009797")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyDotView m_View;

		// Token: 0x04009798 RID: 38808
		[Token(Token = "0x4009798")]
		[FieldOffset(Offset = "0x60")]
		public int DotIndex;
	}
}
