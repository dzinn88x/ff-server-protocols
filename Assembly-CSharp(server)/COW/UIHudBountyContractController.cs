using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001885 RID: 6277
	[Token(Token = "0x2001885")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F440C", Offset = "0x10F440C")]
	internal class UIHudBountyContractController : UIHudButtonBaseController
	{
		// Token: 0x06007C37 RID: 31799 RVA: 0x00022218 File Offset: 0x00020418
		[Token(Token = "0x6007C37")]
		[Address(RVA = "0x189E454", Offset = "0x189E454", VA = "0x7BBC09E454")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C38")]
		[Address(RVA = "0x189E4A4", Offset = "0x189E4A4", VA = "0x7BBC09E4A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C39")]
		[Address(RVA = "0x189E660", Offset = "0x189E660", VA = "0x7BBC09E660", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C3A")]
		[Address(RVA = "0x189E7D4", Offset = "0x189E7D4", VA = "0x7BBC09E7D4", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3B")]
		[Address(RVA = "0x189E81C", Offset = "0x189E81C", VA = "0x7BBC09E81C")]
		private void ShowBountyIcon(params object[] param)
		{
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00022230 File Offset: 0x00020430
		[Token(Token = "0x6007C3C")]
		[Address(RVA = "0x189E97C", Offset = "0x189E97C", VA = "0x7BBC09E97C")]
		private bool ShouldShow()
		{
			return default(bool);
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3D")]
		[Address(RVA = "0x189EAF8", Offset = "0x189EAF8", VA = "0x7BBC09EAF8")]
		private void OnUpdateLoadoutCount(params object[] param)
		{
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3E")]
		[Address(RVA = "0x189EC88", Offset = "0x189EC88", VA = "0x7BBC09EC88")]
		private void OnGameOpenningEnd(params object[] param)
		{
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3F")]
		[Address(RVA = "0x189ED70", Offset = "0x189ED70", VA = "0x7BBC09ED70")]
		private void ShowTutorial()
		{
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C40")]
		[Address(RVA = "0x189EEAC", Offset = "0x189EEAC", VA = "0x7BBC09EEAC")]
		public UIHudBountyContractController()
		{
		}

		// Token: 0x0400904F RID: 36943
		[Token(Token = "0x400904F")]
		[FieldOffset(Offset = "0x60")]
		private UIHudBountyContractView m_View;

		// Token: 0x04009050 RID: 36944
		[Token(Token = "0x4009050")]
		[FieldOffset(Offset = "0x68")]
		private bool needShow;

		// Token: 0x04009051 RID: 36945
		[Token(Token = "0x4009051")]
		[FieldOffset(Offset = "0x69")]
		private bool HasShownTutorial;
	}
}
