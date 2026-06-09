using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020014CF RID: 5327
	[Token(Token = "0x20014CF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDA0C", Offset = "0x10EDA0C")]
	internal class UIHudCSSORoundResultController : UIBaseController
	{
		// Token: 0x06005AEB RID: 23275 RVA: 0x0001AA48 File Offset: 0x00018C48
		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0x19C9010", Offset = "0x19C9010", VA = "0x7BBC1C9010")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0x19C9060", Offset = "0x19C9060", VA = "0x7BBC1C9060", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AED")]
		[Address(RVA = "0x19C92C8", Offset = "0x19C92C8", VA = "0x7BBC1C92C8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0x19C93E8", Offset = "0x19C93E8", VA = "0x7BBC1C93E8")]
		private void OnEarnedCoinChanged(params object[] data)
		{
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0x19C94D0", Offset = "0x19C94D0", VA = "0x7BBC1C94D0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0x19C9CFC", Offset = "0x19C9CFC", VA = "0x7BBC1C9CFC")]
		public void SetBonusDetailsView(<<EMPTY_NAME>> res)
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0x19CA5D0", Offset = "0x19CA5D0", VA = "0x7BBC1CA5D0")]
		private string GetDescriptionOfBonusType(kh{rwd\u0081 bonusType)
		{
			return null;
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0x19C9820", Offset = "0x19C9820", VA = "0x7BBC1C9820")]
		private void SetTeamInfo()
		{
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0x19CA918", Offset = "0x19CA918", VA = "0x7BBC1CA918")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AF4")]
		[Address(RVA = "0x19CB09C", Offset = "0x19CB09C", VA = "0x7BBC1CB09C")]
		public UIHudCSSORoundResultController()
		{
		}

		// Token: 0x04007DA7 RID: 32167
		[Token(Token = "0x4007DA7")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSSORoundResultView m_View;

		// Token: 0x04007DA8 RID: 32168
		[Token(Token = "0x4007DA8")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007DA9 RID: 32169
		[Token(Token = "0x4007DA9")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_BonusItemList;

		// Token: 0x04007DAA RID: 32170
		[Token(Token = "0x4007DAA")]
		[FieldOffset(Offset = "0x70")]
		private BmPqYDk m_Game;

		// Token: 0x04007DAB RID: 32171
		[Token(Token = "0x4007DAB")]
		[FieldOffset(Offset = "0x78")]
		private byte m_MyTeamID;

		// Token: 0x04007DAC RID: 32172
		[Token(Token = "0x4007DAC")]
		[FieldOffset(Offset = "0x79")]
		private byte m_CurrRoundOppoTeamID;

		// Token: 0x04007DAD RID: 32173
		[Token(Token = "0x4007DAD")]
		private const string BONUESCOINSKEY = "${0}";

		// Token: 0x04007DAE RID: 32174
		[Token(Token = "0x4007DAE")]
		[FieldOffset(Offset = "0x7A")]
		private bool m_LocalPlayerWin;

		// Token: 0x04007DAF RID: 32175
		[Token(Token = "0x4007DAF")]
		[FieldOffset(Offset = "0x7B")]
		private bool m_IsSpecial;

		// Token: 0x04007DB0 RID: 32176
		[Token(Token = "0x4007DB0")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_HasMVP;
	}
}
