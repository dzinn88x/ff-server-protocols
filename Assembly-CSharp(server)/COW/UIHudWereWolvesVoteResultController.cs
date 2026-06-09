using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019A5 RID: 6565
	[Token(Token = "0x20019A5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6C64", Offset = "0x10F6C64")]
	public class UIHudWereWolvesVoteResultController : UIBaseController
	{
		// Token: 0x06008675 RID: 34421 RVA: 0x00024630 File Offset: 0x00022830
		[Token(Token = "0x6008675")]
		[Address(RVA = "0x1D1EB10", Offset = "0x1D1EB10", VA = "0x7BBC51EB10")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008676")]
		[Address(RVA = "0x1D1EB60", Offset = "0x1D1EB60", VA = "0x7BBC51EB60", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008677")]
		[Address(RVA = "0x1D1EC44", Offset = "0x1D1EC44", VA = "0x7BBC51EC44", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008678")]
		[Address(RVA = "0x1D1ED10", Offset = "0x1D1ED10", VA = "0x7BBC51ED10", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008679")]
		[Address(RVA = "0x1D1ED44", Offset = "0x1D1ED44", VA = "0x7BBC51ED44")]
		private void OnBannerInfo(params object[] data)
		{
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600867A")]
		[Address(RVA = "0x1D1F4D8", Offset = "0x1D1F4D8", VA = "0x7BBC51F4D8")]
		public UIHudWereWolvesVoteResultController()
		{
		}

		// Token: 0x04009587 RID: 38279
		[Token(Token = "0x4009587")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesVoteResultView m_View;

		// Token: 0x020019A6 RID: 6566
		[Token(Token = "0x20019A6")]
		public enum WereWolvesBannerType
		{
			// Token: 0x04009589 RID: 38281
			[Token(Token = "0x4009589")]
			Eject,
			// Token: 0x0400958A RID: 38282
			[Token(Token = "0x400958A")]
			Alert
		}
	}
}
