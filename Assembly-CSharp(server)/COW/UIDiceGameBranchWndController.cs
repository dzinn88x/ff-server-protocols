using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001392 RID: 5010
	[Token(Token = "0x2001392")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB830", Offset = "0x10EB830")]
	public class UIDiceGameBranchWndController : UIPopupWindowController
	{
		// Token: 0x060050C6 RID: 20678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x21F849C", Offset = "0x21F849C", VA = "0x7BBC9F849C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00018798 File Offset: 0x00016998
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x21F8778", Offset = "0x21F8778", VA = "0x7BBC9F8778")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x21F87C8", Offset = "0x21F87C8", VA = "0x7BBC9F87C8")]
		public void SetData(DiceGameBranchData data)
		{
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x21F9150", Offset = "0x21F9150", VA = "0x7BBC9F9150")]
		private void SetIconView(uint id1, uint id2)
		{
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x21F9374", Offset = "0x21F9374", VA = "0x7BBC9F9374")]
		private void SetEventView(uint id1)
		{
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CB")]
		[Address(RVA = "0x21F960C", Offset = "0x21F960C", VA = "0x7BBC9F960C")]
		private void OnOpt1Click()
		{
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x21F9678", Offset = "0x21F9678", VA = "0x7BBC9F9678")]
		private void OnOpt2Click()
		{
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CD")]
		[Address(RVA = "0x21F963C", Offset = "0x21F963C", VA = "0x7BBC9F963C")]
		private void CloseWnd()
		{
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x000187B0 File Offset: 0x000169B0
		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x21F96A8", Offset = "0x21F96A8", VA = "0x7BBC9F96A8", Slot = "37")]
		public override bool IgnoreEsc()
		{
			return default(bool);
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x21F96B0", Offset = "0x21F96B0", VA = "0x7BBC9F96B0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D0")]
		[Address(RVA = "0x21F975C", Offset = "0x21F975C", VA = "0x7BBC9F975C")]
		public UIDiceGameBranchWndController()
		{
		}

		// Token: 0x04007759 RID: 30553
		[Token(Token = "0x4007759")]
		[FieldOffset(Offset = "0x98")]
		private UIDiceGameBranchWndView m_View;

		// Token: 0x0400775A RID: 30554
		[Token(Token = "0x400775A")]
		[FieldOffset(Offset = "0xA0")]
		private Action Opt1;

		// Token: 0x0400775B RID: 30555
		[Token(Token = "0x400775B")]
		[FieldOffset(Offset = "0xA8")]
		private Action Opt2;

		// Token: 0x0400775C RID: 30556
		[Token(Token = "0x400775C")]
		[FieldOffset(Offset = "0xB0")]
		private Action CloseAction;
	}
}
