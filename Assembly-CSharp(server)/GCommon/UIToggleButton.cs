using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200103F RID: 4159
	[Token(Token = "0x200103F")]
	public class UIToggleButton : UIButton
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074C")]
		private UIWidget SelectWidget
		{
			[Token(Token = "0x6003F62")]
			[Address(RVA = "0x223686C", Offset = "0x223686C", VA = "0x7BBCA3686C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074D")]
		private UIWidget UnselectWidget
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0x2236A00", Offset = "0x2236A00", VA = "0x7BBCA36A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x00013AB8 File Offset: 0x00011CB8
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074E")]
		public bool IsSelected
		{
			[Token(Token = "0x6003F64")]
			[Address(RVA = "0x2236B94", Offset = "0x2236B94", VA = "0x7BBCA36B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F65")]
			[Address(RVA = "0x2236B9C", Offset = "0x2236B9C", VA = "0x7BBCA36B9C")]
			set
			{
			}
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x2236BFC", Offset = "0x2236BFC", VA = "0x7BBCA36BFC")]
		private void Awake()
		{
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x2236CA8", Offset = "0x2236CA8", VA = "0x7BBCA36CA8", Slot = "7")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x2236BDC", Offset = "0x2236BDC", VA = "0x7BBCA36BDC")]
		private void OnToggleSelected()
		{
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x2237448", Offset = "0x2237448", VA = "0x7BBCA37448")]
		public void RefreshButtonStates()
		{
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x2237758", Offset = "0x2237758", VA = "0x7BBCA37758")]
		public UIToggleButton()
		{
		}

		// Token: 0x04004F6D RID: 20333
		[Token(Token = "0x4004F6D")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject SelectedObject;

		// Token: 0x04004F6E RID: 20334
		[Token(Token = "0x4004F6E")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject UnSelectedObject;

		// Token: 0x04004F6F RID: 20335
		[Token(Token = "0x4004F6F")]
		[FieldOffset(Offset = "0x100")]
		public bool IsDefault;

		// Token: 0x04004F70 RID: 20336
		[Token(Token = "0x4004F70")]
		[FieldOffset(Offset = "0x104")]
		public UIToggleButton.SwitchType Switch;

		// Token: 0x04004F71 RID: 20337
		[Token(Token = "0x4004F71")]
		[FieldOffset(Offset = "0x108")]
		private bool m_IsSelected;

		// Token: 0x04004F72 RID: 20338
		[Token(Token = "0x4004F72")]
		[FieldOffset(Offset = "0x109")]
		private bool m_Inited;

		// Token: 0x04004F73 RID: 20339
		[Token(Token = "0x4004F73")]
		[FieldOffset(Offset = "0x110")]
		public UIToggleButton.OnSelectDelgate onSelect;

		// Token: 0x04004F74 RID: 20340
		[Token(Token = "0x4004F74")]
		[FieldOffset(Offset = "0x118")]
		private UIWidget m_SelectWidget;

		// Token: 0x04004F75 RID: 20341
		[Token(Token = "0x4004F75")]
		[FieldOffset(Offset = "0x120")]
		private UIWidget m_UnselectWidget;

		// Token: 0x02001040 RID: 4160
		[Token(Token = "0x2001040")]
		public enum SwitchType
		{
			// Token: 0x04004F77 RID: 20343
			[Token(Token = "0x4004F77")]
			Alpha,
			// Token: 0x04004F78 RID: 20344
			[Token(Token = "0x4004F78")]
			Active
		}

		// Token: 0x02001041 RID: 4161
		// (Invoke) Token: 0x06003F6C RID: 16236
		[Token(Token = "0x2001041")]
		[HideInInspector]
		public delegate void OnSelectDelgate(UIToggleButton button);
	}
}
