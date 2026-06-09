using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014BE RID: 5310
	[Token(Token = "0x20014BE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED73C", Offset = "0x10ED73C")]
	public class UIHudCSMysteryBoxOptionItemView : MonoBehaviour
	{
		// Token: 0x06005A42 RID: 23106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A42")]
		[Address(RVA = "0x19C1750", Offset = "0x19C1750", VA = "0x7BBC1C1750")]
		private void Awake()
		{
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A43")]
		[Address(RVA = "0x19C1900", Offset = "0x19C1900", VA = "0x7BBC1C1900")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x19C1A14", Offset = "0x19C1A14", VA = "0x7BBC1C1A14")]
		public void SetUIData(UIHudCSMysteryBoxOptionItemView.MysterBoxData data)
		{
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A45")]
		[Address(RVA = "0x19C1C20", Offset = "0x19C1C20", VA = "0x7BBC1C1C20")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x19C1D6C", Offset = "0x19C1D6C", VA = "0x7BBC1C1D6C")]
		private void OnHelpBtnClick()
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x19C1F50", Offset = "0x19C1F50", VA = "0x7BBC1C1F50")]
		private void OnOptionSelected(params object[] data)
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x19C1F80", Offset = "0x19C1F80", VA = "0x7BBC1C1F80")]
		public UIHudCSMysteryBoxOptionItemView()
		{
		}

		// Token: 0x04007D4E RID: 32078
		[Token(Token = "0x4007D4E")]
		[FieldOffset(Offset = "0x18")]
		public UIToggleButton ItemBtn;

		// Token: 0x04007D4F RID: 32079
		[Token(Token = "0x4007D4F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ItemName;

		// Token: 0x04007D50 RID: 32080
		[Token(Token = "0x4007D50")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemSprite;

		// Token: 0x04007D51 RID: 32081
		[Token(Token = "0x4007D51")]
		[FieldOffset(Offset = "0x30")]
		public UIButton HelpBtn;

		// Token: 0x04007D52 RID: 32082
		[Token(Token = "0x4007D52")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SelectedHL;

		// Token: 0x04007D53 RID: 32083
		[Token(Token = "0x4007D53")]
		[FieldOffset(Offset = "0x40")]
		private UIHudCSMysteryBoxOptionItemView.MysterBoxData m_BoxData;

		// Token: 0x04007D54 RID: 32084
		[Token(Token = "0x4007D54")]
		[FieldOffset(Offset = "0x50")]
		private UIHudCommonlTipsController m_CurrentTips;

		// Token: 0x020014BF RID: 5311
		[Token(Token = "0x20014BF")]
		public struct MysterBoxData
		{
			// Token: 0x04007D55 RID: 32085
			[Token(Token = "0x4007D55")]
			[FieldOffset(Offset = "0x0")]
			public uint boxItemID;

			// Token: 0x04007D56 RID: 32086
			[Token(Token = "0x4007D56")]
			[FieldOffset(Offset = "0x4")]
			public uint boxUniqueID;

			// Token: 0x04007D57 RID: 32087
			[Token(Token = "0x4007D57")]
			[FieldOffset(Offset = "0x8")]
			public uint boxIndexID;

			// Token: 0x04007D58 RID: 32088
			[Token(Token = "0x4007D58")]
			[FieldOffset(Offset = "0xC")]
			public uint itemID;
		}
	}
}
