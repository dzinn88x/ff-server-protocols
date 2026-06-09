using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C6A RID: 7274
	[Token(Token = "0x2001C6A")]
	public class UISettingToggleGroup : MonoBehaviour
	{
		// Token: 0x06009E90 RID: 40592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E90")]
		[Address(RVA = "0x16365EC", Offset = "0x16365EC", VA = "0x7BBBE365EC")]
		private void Awake()
		{
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E91")]
		[Address(RVA = "0x16368B0", Offset = "0x16368B0", VA = "0x7BBBE368B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E92")]
		[Address(RVA = "0x1636AD8", Offset = "0x1636AD8", VA = "0x7BBBE36AD8")]
		private void Start()
		{
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E93")]
		[Address(RVA = "0x1636BEC", Offset = "0x1636BEC", VA = "0x7BBBE36BEC")]
		public void SetNewKey(string on, string off)
		{
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E94")]
		[Address(RVA = "0x1636ADC", Offset = "0x1636ADC", VA = "0x7BBBE36ADC")]
		public void SetTogglesGroup()
		{
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E95")]
		[Address(RVA = "0x1636DB8", Offset = "0x1636DB8", VA = "0x7BBBE36DB8")]
		private void OnValueChange()
		{
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E96")]
		[Address(RVA = "0x16373FC", Offset = "0x16373FC", VA = "0x7BBBE373FC")]
		public void SetLocTitleKey(string locKey)
		{
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E97")]
		[Address(RVA = "0x163751C", Offset = "0x163751C", VA = "0x7BBBE3751C")]
		public void SetToggleValue(int value)
		{
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E98")]
		[Address(RVA = "0x16377BC", Offset = "0x16377BC", VA = "0x7BBBE377BC")]
		public UISettingToggleGroup()
		{
		}

		// Token: 0x0400A4EC RID: 42220
		[Token(Token = "0x400A4EC")]
		[FieldOffset(Offset = "0x18")]
		public UIToggle[] m_Toggles;

		// Token: 0x0400A4ED RID: 42221
		[Token(Token = "0x400A4ED")]
		[FieldOffset(Offset = "0x20")]
		public int[] m_Contents;

		// Token: 0x0400A4EE RID: 42222
		[Token(Token = "0x400A4EE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel[] m_Labels;

		// Token: 0x0400A4EF RID: 42223
		[Token(Token = "0x400A4EF")]
		[FieldOffset(Offset = "0x30")]
		public string m_SettingKey;

		// Token: 0x0400A4F0 RID: 42224
		[Token(Token = "0x400A4F0")]
		[FieldOffset(Offset = "0x38")]
		public int m_DefaultContent;

		// Token: 0x0400A4F1 RID: 42225
		[Token(Token = "0x400A4F1")]
		[FieldOffset(Offset = "0x3C")]
		public bool isReloadingWorks;

		// Token: 0x0400A4F2 RID: 42226
		[Token(Token = "0x400A4F2")]
		[FieldOffset(Offset = "0x3D")]
		private bool isInitShow;

		// Token: 0x0400A4F3 RID: 42227
		[Token(Token = "0x400A4F3")]
		[FieldOffset(Offset = "0x40")]
		private UIToggleValue[] m_ToggleValueItems;

		// Token: 0x0400A4F4 RID: 42228
		[Token(Token = "0x400A4F4")]
		[FieldOffset(Offset = "0x48")]
		public OnToggleGroupValueChange OnToggleValueChange;

		// Token: 0x0400A4F5 RID: 42229
		[Token(Token = "0x400A4F5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel m_LocTitle;

		// Token: 0x0400A4F6 RID: 42230
		[Token(Token = "0x400A4F6")]
		[FieldOffset(Offset = "0x58")]
		public UILabel m_OnLabel;

		// Token: 0x0400A4F7 RID: 42231
		[Token(Token = "0x400A4F7")]
		[FieldOffset(Offset = "0x60")]
		public UILabel m_OffLabel;

		// Token: 0x0400A4F8 RID: 42232
		[Token(Token = "0x400A4F8")]
		[FieldOffset(Offset = "0x68")]
		public Color OnColor;

		// Token: 0x0400A4F9 RID: 42233
		[Token(Token = "0x400A4F9")]
		[FieldOffset(Offset = "0x78")]
		public Color OffColor;

		// Token: 0x0400A4FA RID: 42234
		[Token(Token = "0x400A4FA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_HasInit;
	}
}
