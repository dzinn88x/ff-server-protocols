using System;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200153A RID: 5434
	[Token(Token = "0x200153A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE4DC", Offset = "0x10EE4DC")]
	internal class UILadderMatchSeasonInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005DCA RID: 24010 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x6005DCA")]
		[Address(RVA = "0x1E95B7C", Offset = "0x1E95B7C", VA = "0x7BBC695B7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCB")]
		[Address(RVA = "0x1E95BCC", Offset = "0x1E95BCC", VA = "0x7BBC695BCC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCC")]
		[Address(RVA = "0x1E96488", Offset = "0x1E96488", VA = "0x7BBC696488", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCD")]
		[Address(RVA = "0x1E965C0", Offset = "0x1E965C0", VA = "0x7BBC6965C0")]
		private void OnTweenFinish()
		{
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCE")]
		[Address(RVA = "0x1E8BE7C", Offset = "0x1E8BE7C", VA = "0x7BBC68BE7C")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DCF")]
		[Address(RVA = "0x1E966B4", Offset = "0x1E966B4", VA = "0x7BBC6966B4")]
		private void RefreshCSData(params object[] data)
		{
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0x1E97274", Offset = "0x1E97274", VA = "0x7BBC697274")]
		private void RefreshBRPeakRank()
		{
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD1")]
		[Address(RVA = "0x1E97B38", Offset = "0x1E97B38", VA = "0x7BBC697B38")]
		private void RefreshBRData()
		{
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD2")]
		[Address(RVA = "0x1E98678", Offset = "0x1E98678", VA = "0x7BBC698678")]
		private void OnRuleClicked()
		{
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD3")]
		[Address(RVA = "0x1E9872C", Offset = "0x1E9872C", VA = "0x7BBC69872C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0x1E989E0", Offset = "0x1E989E0", VA = "0x7BBC6989E0", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x1E98A24", Offset = "0x1E98A24", VA = "0x7BBC698A24")]
		public UILadderMatchSeasonInfoController()
		{
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0x1E98AA4", Offset = "0x1E98AA4", VA = "0x7BBC698AA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FAAC", Offset = "0x113FAAC")]
		private void <OnUIInit>b__6_0()
		{
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x1E98C2C", Offset = "0x1E98C2C", VA = "0x7BBC698C2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FABC", Offset = "0x113FABC")]
		private void <OnUIInit>b__6_1()
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0x1E98C70", Offset = "0x1E98C70", VA = "0x7BBC698C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FACC", Offset = "0x113FACC")]
		private void <RefreshBRPeakRank>b__11_0()
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x1E98CCC", Offset = "0x1E98CCC", VA = "0x7BBC698CCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FADC", Offset = "0x113FADC")]
		private void <RefreshBRPeakRank>b__11_1()
		{
		}

		// Token: 0x04007F72 RID: 32626
		[Token(Token = "0x4007F72")]
		[FieldOffset(Offset = "0x58")]
		private LadderMatchSeasonInfoView m_View;

		// Token: 0x04007F73 RID: 32627
		[Token(Token = "0x4007F73")]
		[FieldOffset(Offset = "0x60")]
		private GameObject[] m_CSStarArray;

		// Token: 0x04007F74 RID: 32628
		[Token(Token = "0x4007F74")]
		[FieldOffset(Offset = "0x68")]
		private GameObject[] m_CSBlackStarArray;

		// Token: 0x04007F75 RID: 32629
		[Token(Token = "0x4007F75")]
		[FieldOffset(Offset = "0x70")]
		private Color32 m_LowPointColor;

		// Token: 0x04007F76 RID: 32630
		[Token(Token = "0x4007F76")]
		[FieldOffset(Offset = "0x74")]
		private Color32 m_HighPointColor;
	}
}
