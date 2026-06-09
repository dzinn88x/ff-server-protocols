using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002090 RID: 8336
	[Token(Token = "0x2002090")]
	internal class UITokenGameScene : UITeamModeBaseGameScene
	{
		// Token: 0x0600BB1C RID: 47900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1C")]
		[Address(RVA = "0x1F55374", Offset = "0x1F55374", VA = "0x7BBC755374", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1D")]
		[Address(RVA = "0x1F55538", Offset = "0x1F55538", VA = "0x7BBC755538", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1E")]
		[Address(RVA = "0x1F556FC", Offset = "0x1F556FC", VA = "0x7BBC7556FC")]
		public void OnIntroInfoDone(params object[] data)
		{
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1F")]
		[Address(RVA = "0x1F55708", Offset = "0x1F55708", VA = "0x7BBC755708")]
		public void OnIntroInfoShow(params object[] data)
		{
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB20")]
		[Address(RVA = "0x1F557F8", Offset = "0x1F557F8", VA = "0x7BBC7557F8")]
		private void OnShowCombo(params object[] data)
		{
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB21")]
		[Address(RVA = "0x1F55B10", Offset = "0x1F55B10", VA = "0x7BBC755B10", Slot = "28")]
		protected override Type GetMatchEndShowHUD()
		{
			return null;
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB22")]
		[Address(RVA = "0x1F55B80", Offset = "0x1F55B80", VA = "0x7BBC755B80", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB23")]
		[Address(RVA = "0x1F55BF0", Offset = "0x1F55BF0", VA = "0x7BBC755BF0")]
		public UITokenGameScene()
		{
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB24")]
		[Address(RVA = "0x1F55C5C", Offset = "0x1F55C5C", VA = "0x7BBC755C5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147CD4", Offset = "0x1147CD4")]
		private void <OnIntroInfoShow>b__5_0()
		{
		}

		// Token: 0x0400BC3B RID: 48187
		[Token(Token = "0x400BC3B")]
		[FieldOffset(Offset = "0x3E8")]
		private bool m_IntroInfoDone;

		// Token: 0x0400BC3C RID: 48188
		[Token(Token = "0x400BC3C")]
		[FieldOffset(Offset = "0x3F0")]
		private List<UIHudTokenComboController> m_ConboCtrls;
	}
}
