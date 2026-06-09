using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001867 RID: 6247
	[Token(Token = "0x2001867")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3F6C", Offset = "0x10F3F6C")]
	internal class UIHudActionController : UIHudButtonBaseController
	{
		// Token: 0x06007B20 RID: 31520 RVA: 0x00021E10 File Offset: 0x00020010
		[Token(Token = "0x6007B20")]
		[Address(RVA = "0x1D660EC", Offset = "0x1D660EC", VA = "0x7BBC5660EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B21")]
		[Address(RVA = "0x1D6613C", Offset = "0x1D6613C", VA = "0x7BBC56613C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B22")]
		[Address(RVA = "0x1D66334", Offset = "0x1D66334", VA = "0x7BBC566334", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B23")]
		[Address(RVA = "0x1D664A8", Offset = "0x1D664A8", VA = "0x7BBC5664A8", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B24")]
		[Address(RVA = "0x1D664F0", Offset = "0x1D664F0", VA = "0x7BBC5664F0")]
		private void OnActionEnter(params object[] param)
		{
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B25")]
		[Address(RVA = "0x1D68A84", Offset = "0x1D68A84", VA = "0x7BBC568A84")]
		private void OnActionEnd(params object[] param)
		{
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B26")]
		[Address(RVA = "0x1D68ADC", Offset = "0x1D68ADC", VA = "0x7BBC568ADC")]
		protected void OnShow(params object[] param)
		{
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B27")]
		[Address(RVA = "0x1D68708", Offset = "0x1D68708", VA = "0x7BBC568708")]
		private void SetToDefault()
		{
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B28")]
		[Address(RVA = "0x1D68BD0", Offset = "0x1D68BD0", VA = "0x7BBC568BD0")]
		private void ShowTutorialForOpenParachute()
		{
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B29")]
		[Address(RVA = "0x1D68C70", Offset = "0x1D68C70", VA = "0x7BBC568C70", Slot = "30")]
		protected override void OnBtnClick()
		{
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2A")]
		[Address(RVA = "0x1D68D00", Offset = "0x1D68D00", VA = "0x7BBC568D00", Slot = "32")]
		protected override void OnBtnRelease()
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2B")]
		[Address(RVA = "0x1D68D8C", Offset = "0x1D68D8C", VA = "0x7BBC568D8C")]
		public UIHudActionController()
		{
		}

		// Token: 0x04008FB0 RID: 36784
		[Token(Token = "0x4008FB0")]
		[FieldOffset(Offset = "0x60")]
		private UIHudActionView m_View;

		// Token: 0x04008FB1 RID: 36785
		[Token(Token = "0x4008FB1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ACTIONICON_DEFAULT;

		// Token: 0x04008FB2 RID: 36786
		[Token(Token = "0x4008FB2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string ACTIONICON_STROP;

		// Token: 0x04008FB3 RID: 36787
		[Token(Token = "0x4008FB3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ACTIONICON_QUIT;

		// Token: 0x04008FB4 RID: 36788
		[Token(Token = "0x4008FB4")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string ACTIONICON_USE;

		// Token: 0x04008FB5 RID: 36789
		[Token(Token = "0x4008FB5")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string ACTIONICON_ENTER;

		// Token: 0x04008FB6 RID: 36790
		[Token(Token = "0x4008FB6")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string ACTIONICON_BUY;

		// Token: 0x04008FB7 RID: 36791
		[Token(Token = "0x4008FB7")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string ACTIONICONBG_DEFAULT;

		// Token: 0x04008FB8 RID: 36792
		[Token(Token = "0x4008FB8")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string ACTIONICONBG_STROP;

		// Token: 0x04008FB9 RID: 36793
		[Token(Token = "0x4008FB9")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string ACTIONICONBG_OPEN;

		// Token: 0x04008FBA RID: 36794
		[Token(Token = "0x4008FBA")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string ACTIONICONBG_OPEN_FLIGHT;

		// Token: 0x04008FBB RID: 36795
		[Token(Token = "0x4008FBB")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string ACTIONICONBG_FALL;

		// Token: 0x04008FBC RID: 36796
		[Token(Token = "0x4008FBC")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string ACTIONICONBG_REVIVE;

		// Token: 0x04008FBD RID: 36797
		[Token(Token = "0x4008FBD")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string ACTIONICONBG_DRIFTBOTTLE;

		// Token: 0x04008FBE RID: 36798
		[Token(Token = "0x4008FBE")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string ACTIONICONBG_FOLLOWEMOTE;

		// Token: 0x04008FBF RID: 36799
		[Token(Token = "0x4008FBF")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string ACTIONICONBG_BOXING;

		// Token: 0x04008FC0 RID: 36800
		[Token(Token = "0x4008FC0")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Color ACTIONICONBG_COLOR_STROP;

		// Token: 0x04008FC1 RID: 36801
		[Token(Token = "0x4008FC1")]
		[FieldOffset(Offset = "0x88")]
		public static readonly Vector3 LOCALPOSITION_DEFAULT;

		// Token: 0x04008FC2 RID: 36802
		[Token(Token = "0x4008FC2")]
		[FieldOffset(Offset = "0x94")]
		public static readonly Vector3 DefaultLabelPos;

		// Token: 0x04008FC3 RID: 36803
		[Token(Token = "0x4008FC3")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly Vector3 SpecialLabelPos;

		// Token: 0x04008FC4 RID: 36804
		[Token(Token = "0x4008FC4")]
		[FieldOffset(Offset = "0x68")]
		private EHudActionType m_ActType;

		// Token: 0x04008FC5 RID: 36805
		[Token(Token = "0x4008FC5")]
		[FieldOffset(Offset = "0x6C")]
		private Color SpeicalBgColor;

		// Token: 0x04008FC6 RID: 36806
		[Token(Token = "0x4008FC6")]
		[FieldOffset(Offset = "0x7C")]
		private Color DefaultBgColor;

		// Token: 0x04008FC7 RID: 36807
		[Token(Token = "0x4008FC7")]
		[FieldOffset(Offset = "0x90")]
		private BoxCollider m_Coiilder;

		// Token: 0x04008FC8 RID: 36808
		[Token(Token = "0x4008FC8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_TutJumpShowed;

		// Token: 0x04008FC9 RID: 36809
		[Token(Token = "0x4008FC9")]
		[FieldOffset(Offset = "0x99")]
		private bool m_TutOpenParachuteShowed;

		// Token: 0x04008FCA RID: 36810
		[Token(Token = "0x4008FCA")]
		[FieldOffset(Offset = "0x9A")]
		private bool m_ShowState;
	}
}
