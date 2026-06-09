using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200186C RID: 6252
	[Token(Token = "0x200186C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F405C", Offset = "0x10F405C")]
	internal class UIHudAOHLevelUpHintController : UIBaseController
	{
		// Token: 0x06007B4F RID: 31567 RVA: 0x00021EA0 File Offset: 0x000200A0
		[Token(Token = "0x6007B4F")]
		[Address(RVA = "0x1D64620", Offset = "0x1D64620", VA = "0x7BBC564620")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B50")]
		[Address(RVA = "0x1D64670", Offset = "0x1D64670", VA = "0x7BBC564670", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B51")]
		[Address(RVA = "0x1D64864", Offset = "0x1D64864", VA = "0x7BBC564864", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B52")]
		[Address(RVA = "0x1D64984", Offset = "0x1D64984", VA = "0x7BBC564984")]
		private void OnBigHeadLevelChange(params object[] data)
		{
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B53")]
		[Address(RVA = "0x1D64BC0", Offset = "0x1D64BC0", VA = "0x7BBC564BC0")]
		private void OnAOHPhaseChange(params object[] data)
		{
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B54")]
		[Address(RVA = "0x1D64F28", Offset = "0x1D64F28", VA = "0x7BBC564F28", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B55")]
		[Address(RVA = "0x1D65054", Offset = "0x1D65054", VA = "0x7BBC565054")]
		public UIHudAOHLevelUpHintController()
		{
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B56")]
		[Address(RVA = "0x1D6505C", Offset = "0x1D6505C", VA = "0x7BBC56505C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11427A4", Offset = "0x11427A4")]
		private void <Show>b__8_0()
		{
		}

		// Token: 0x04008FDF RID: 36831
		[Token(Token = "0x4008FDF")]
		[FieldOffset(Offset = "0x58")]
		private UIHudAOHLevelUpHintView m_View;

		// Token: 0x04008FE0 RID: 36832
		[Token(Token = "0x4008FE0")]
		[FieldOffset(Offset = "0x60")]
		private BigHeadDataConfig m_BigHeadDataConfig;

		// Token: 0x04008FE1 RID: 36833
		[Token(Token = "0x4008FE1")]
		[FieldOffset(Offset = "0x68")]
		private uint m_HideDelayCall;
	}
}
