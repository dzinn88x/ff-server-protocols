using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001042 RID: 4162
	[Token(Token = "0x2001042")]
	public class UIToggleButtonGroup : MonoBehaviour
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x22377A0", Offset = "0x22377A0", VA = "0x7BBCA377A0")]
		private void Awake()
		{
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x22377AC", Offset = "0x22377AC", VA = "0x7BBCA377AC", Slot = "4")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x2237D7C", Offset = "0x2237D7C", VA = "0x7BBCA37D7C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x2237D84", Offset = "0x2237D84", VA = "0x7BBCA37D84")]
		public void ResetAllToggleButton()
		{
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x2237F00", Offset = "0x2237F00", VA = "0x7BBCA37F00", Slot = "5")]
		public virtual void OnSelectButton(UIToggleButton selectedButton)
		{
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x22388B4", Offset = "0x22388B4", VA = "0x7BBCA388B4")]
		public void OnSelectItemByIndex(int index)
		{
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x2238804", Offset = "0x2238804", VA = "0x7BBCA38804")]
		public void RefreshButtonStates()
		{
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x2237E00", Offset = "0x2237E00", VA = "0x7BBCA37E00")]
		public void RebindButtons()
		{
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x2238A70", Offset = "0x2238A70", VA = "0x7BBCA38A70")]
		public UIToggleButtonGroup()
		{
		}

		// Token: 0x04004F79 RID: 20345
		[Token(Token = "0x4004F79")]
		[FieldOffset(Offset = "0x18")]
		public UIToggleButton[] toggleButtons;

		// Token: 0x04004F7A RID: 20346
		[Token(Token = "0x4004F7A")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton DefaultClickBtn;

		// Token: 0x04004F7B RID: 20347
		[Token(Token = "0x4004F7B")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButtonGroup.OnItemSelect OnItemSelectCallback;

		// Token: 0x04004F7C RID: 20348
		[Token(Token = "0x4004F7C")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButtonGroup.OnItemSelect OnItemUnSelectCallback;

		// Token: 0x04004F7D RID: 20349
		[Token(Token = "0x4004F7D")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButtonGroup.OnItemAwakeFinished OnAwakeCallback;

		// Token: 0x02001043 RID: 4163
		// (Invoke) Token: 0x06003F79 RID: 16249
		[Token(Token = "0x2001043")]
		public delegate void OnItemSelect(UIToggleButton selectButton);

		// Token: 0x02001044 RID: 4164
		// (Invoke) Token: 0x06003F7D RID: 16253
		[Token(Token = "0x2001044")]
		public delegate void OnItemUnSelect(UIToggleButton selectButton);

		// Token: 0x02001045 RID: 4165
		// (Invoke) Token: 0x06003F81 RID: 16257
		[Token(Token = "0x2001045")]
		public delegate void OnItemAwakeFinished();
	}
}
