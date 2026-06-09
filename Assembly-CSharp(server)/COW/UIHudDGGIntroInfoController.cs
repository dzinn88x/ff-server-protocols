using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018A7 RID: 6311
	[Token(Token = "0x20018A7")]
	public class UIHudDGGIntroInfoController : UIBaseController
	{
		// Token: 0x06007D56 RID: 32086 RVA: 0x000225D8 File Offset: 0x000207D8
		[Token(Token = "0x6007D56")]
		[Address(RVA = "0x1AA8EA8", Offset = "0x1AA8EA8", VA = "0x7BBC2A8EA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D57")]
		[Address(RVA = "0x1AA8EF8", Offset = "0x1AA8EF8", VA = "0x7BBC2A8EF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D58")]
		[Address(RVA = "0x1AA9584", Offset = "0x1AA9584", VA = "0x7BBC2A9584", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D59")]
		[Address(RVA = "0x1AA9004", Offset = "0x1AA9004", VA = "0x7BBC2A9004")]
		private void UpdateDetailInfo()
		{
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5A")]
		[Address(RVA = "0x1AA962C", Offset = "0x1AA962C", VA = "0x7BBC2A962C")]
		public UIHudDGGIntroInfoController()
		{
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D5B")]
		[Address(RVA = "0x1AA9634", Offset = "0x1AA9634", VA = "0x7BBC2A9634")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142B44", Offset = "0x1142B44")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x040090F1 RID: 37105
		[Token(Token = "0x40090F1")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDGGIntroInfoView m_View;

		// Token: 0x040090F2 RID: 37106
		[Token(Token = "0x40090F2")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
