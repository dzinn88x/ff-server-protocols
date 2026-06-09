using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200101B RID: 4123
	[Token(Token = "0x200101B")]
	public class UIBaseView
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x17000734")]
		public Vector2 WindowsSize
		{
			[Token(Token = "0x6003E44")]
			[Address(RVA = "0x2027F80", Offset = "0x2027F80", VA = "0x7BBC827F80")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000735")]
		public bool FullScreenUI
		{
			[Token(Token = "0x6003E45")]
			[Address(RVA = "0x2027F88", Offset = "0x2027F88", VA = "0x7BBC827F88")]
			set
			{
			}
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E46")]
		[Address(RVA = "0x2027F94", Offset = "0x2027F94", VA = "0x7BBC827F94")]
		public void Init(Transform rootTrans, Transform holder)
		{
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E47")]
		[Address(RVA = "0x2028248", Offset = "0x2028248", VA = "0x7BBC828248", Slot = "4")]
		protected virtual void OnInit(Transform holder)
		{
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E48")]
		[Address(RVA = "0x202824C", Offset = "0x202824C", VA = "0x7BBC82824C")]
		public UIBaseView()
		{
		}

		// Token: 0x04004EA8 RID: 20136
		[Token(Token = "0x4004EA8")]
		[FieldOffset(Offset = "0x10")]
		protected Vector2 m_WindowsSize;

		// Token: 0x04004EA9 RID: 20137
		[Token(Token = "0x4004EA9")]
		[FieldOffset(Offset = "0x18")]
		private bool m_FullScreenUI;
	}
}
