using System;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200153B RID: 5435
	[Token(Token = "0x200153B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE514", Offset = "0x10EE514")]
	internal class UILadderMatchSeasonMiniInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005DDA RID: 24026 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0x1E98D74", Offset = "0x1E98D74", VA = "0x7BBC698D74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x1E98DC4", Offset = "0x1E98DC4", VA = "0x7BBC698DC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x1E99704", Offset = "0x1E99704", VA = "0x7BBC699704", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x1E99880", Offset = "0x1E99880", VA = "0x7BBC699880")]
		private void OnTweenFinish()
		{
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0x1E8C08C", Offset = "0x1E8C08C", VA = "0x7BBC68C08C")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0x1E99974", Offset = "0x1E99974", VA = "0x7BBC699974")]
		private void RefreshCSStatData()
		{
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0x1E99B9C", Offset = "0x1E99B9C", VA = "0x7BBC699B9C")]
		private void RefreshBRStatData()
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0x1E99E60", Offset = "0x1E99E60", VA = "0x7BBC699E60")]
		private void RefreshCSData(params object[] data)
		{
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0x1E9A8A0", Offset = "0x1E9A8A0", VA = "0x7BBC69A8A0")]
		private void RefreshBRData()
		{
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0x1E9B71C", Offset = "0x1E9B71C", VA = "0x7BBC69B71C")]
		private void OnRuleClicked()
		{
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0x1E9B7D0", Offset = "0x1E9B7D0", VA = "0x7BBC69B7D0")]
		private void OnDetailsBtnClick()
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0x1E9B988", Offset = "0x1E9B988", VA = "0x7BBC69B988", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0x1E9BC44", Offset = "0x1E9BC44", VA = "0x7BBC69BC44", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0x1E9BCA8", Offset = "0x1E9BCA8", VA = "0x7BBC69BCA8")]
		public UILadderMatchSeasonMiniInfoController()
		{
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0x1E9BD28", Offset = "0x1E9BD28", VA = "0x7BBC69BD28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FAEC", Offset = "0x113FAEC")]
		private void <OnUIInit>b__7_0()
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0x1E9BEB0", Offset = "0x1E9BEB0", VA = "0x7BBC69BEB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FAFC", Offset = "0x113FAFC")]
		private void <OnUIInit>b__7_1()
		{
		}

		// Token: 0x04007F77 RID: 32631
		[Token(Token = "0x4007F77")]
		[FieldOffset(Offset = "0x58")]
		private LadderMatchSeasonMiniInfoView m_View;

		// Token: 0x04007F78 RID: 32632
		[Token(Token = "0x4007F78")]
		[FieldOffset(Offset = "0x60")]
		private GameObject[] m_CSStarArray;

		// Token: 0x04007F79 RID: 32633
		[Token(Token = "0x4007F79")]
		[FieldOffset(Offset = "0x68")]
		private GameObject[] m_CSBlackStarArray;

		// Token: 0x04007F7A RID: 32634
		[Token(Token = "0x4007F7A")]
		[FieldOffset(Offset = "0x70")]
		private f m_LadderMatchType;

		// Token: 0x04007F7B RID: 32635
		[Token(Token = "0x4007F7B")]
		[FieldOffset(Offset = "0x74")]
		private Color32 m_LowPointColor;

		// Token: 0x04007F7C RID: 32636
		[Token(Token = "0x4007F7C")]
		[FieldOffset(Offset = "0x78")]
		private Color32 m_HighPointColor;
	}
}
