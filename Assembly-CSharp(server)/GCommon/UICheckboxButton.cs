using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200101D RID: 4125
	[Token(Token = "0x200101D")]
	public class UICheckboxButton : UIButton
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x00013620 File Offset: 0x00011820
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000736")]
		public bool IsChecked
		{
			[Token(Token = "0x6003E4D")]
			[Address(RVA = "0x2028254", Offset = "0x2028254", VA = "0x7BBC828254")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E4E")]
			[Address(RVA = "0x202825C", Offset = "0x202825C", VA = "0x7BBC82825C")]
			set
			{
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x2028374", Offset = "0x2028374", VA = "0x7BBC828374")]
		private void Start()
		{
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x2028418", Offset = "0x2028418", VA = "0x7BBC828418")]
		private void Awake()
		{
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x2028420", Offset = "0x2028420", VA = "0x7BBC828420")]
		private void OnCheckBoxTicked()
		{
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x2028464", Offset = "0x2028464", VA = "0x7BBC828464")]
		public UICheckboxButton()
		{
		}

		// Token: 0x04004EAA RID: 20138
		[Token(Token = "0x4004EAA")]
		[FieldOffset(Offset = "0xF0")]
		public bool IsDefualtChecked;

		// Token: 0x04004EAB RID: 20139
		[Token(Token = "0x4004EAB")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject CheckedObject;

		// Token: 0x04004EAC RID: 20140
		[Token(Token = "0x4004EAC")]
		[FieldOffset(Offset = "0x100")]
		public GameObject UnCheckedObject;

		// Token: 0x04004EAD RID: 20141
		[Token(Token = "0x4004EAD")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public OnCheckboxValueChanged OnValueChanged;

		// Token: 0x04004EAE RID: 20142
		[Token(Token = "0x4004EAE")]
		[FieldOffset(Offset = "0x110")]
		private bool m_IsChecked;
	}
}
