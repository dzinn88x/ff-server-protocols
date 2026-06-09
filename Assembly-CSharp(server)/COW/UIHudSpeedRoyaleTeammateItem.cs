using System;
using COW.GamePlay;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C6F RID: 7279
	[Token(Token = "0x2001C6F")]
	internal class UIHudSpeedRoyaleTeammateItem : MonoBehaviour
	{
		// Token: 0x06009EB4 RID: 40628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB4")]
		[Address(RVA = "0x166DF90", Offset = "0x166DF90", VA = "0x7BBBE6DF90")]
		public void Show(bool v)
		{
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB5")]
		[Address(RVA = "0x166DFCC", Offset = "0x166DFCC", VA = "0x7BBBE6DFCC")]
		public void InitInfo(Player p)
		{
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB6")]
		[Address(RVA = "0x166E774", Offset = "0x166E774", VA = "0x7BBBE6E774")]
		public void InitWithPlayerInfo(^|dlTwk playerInfo)
		{
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB7")]
		[Address(RVA = "0x166E73C", Offset = "0x166E73C", VA = "0x7BBBE6E73C")]
		public void SetVoiceVisible(bool flag)
		{
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB8")]
		[Address(RVA = "0x166E9C8", Offset = "0x166E9C8", VA = "0x7BBBE6E9C8")]
		public void SetMarkShow(bool show)
		{
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB9")]
		[Address(RVA = "0x166E5AC", Offset = "0x166E5AC", VA = "0x7BBBE6E5AC")]
		public void SetTeammateState(ETeammateState nextState)
		{
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBA")]
		[Address(RVA = "0x166E4CC", Offset = "0x166E4CC", VA = "0x7BBBE6E4CC")]
		public void SetDisconnected(bool disconnected)
		{
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBB")]
		[Address(RVA = "0x166E2D4", Offset = "0x166E2D4", VA = "0x7BBBE6E2D4")]
		public void OnHPChanged(Player p)
		{
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBC")]
		[Address(RVA = "0x166EA18", Offset = "0x166EA18", VA = "0x7BBBE6EA18")]
		public UIHudSpeedRoyaleTeammateItem()
		{
		}

		// Token: 0x0400A51B RID: 42267
		[Token(Token = "0x400A51B")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Name;

		// Token: 0x0400A51C RID: 42268
		[Token(Token = "0x400A51C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HPBarGO;

		// Token: 0x0400A51D RID: 42269
		[Token(Token = "0x400A51D")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HP;

		// Token: 0x0400A51E RID: 42270
		[Token(Token = "0x400A51E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Mark;

		// Token: 0x0400A51F RID: 42271
		[Token(Token = "0x400A51F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject KillerGO;

		// Token: 0x0400A520 RID: 42272
		[Token(Token = "0x400A520")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TeamIndex;

		// Token: 0x0400A521 RID: 42273
		[Token(Token = "0x400A521")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Offline;

		// Token: 0x0400A522 RID: 42274
		[Token(Token = "0x400A522")]
		[FieldOffset(Offset = "0x50")]
		public UISprite DisFlag;

		// Token: 0x0400A523 RID: 42275
		[Token(Token = "0x400A523")]
		[FieldOffset(Offset = "0x58")]
		public GameObject VoiceGO;

		// Token: 0x0400A524 RID: 42276
		[Token(Token = "0x400A524")]
		[FieldOffset(Offset = "0x60")]
		private ETeammateState m_CurrentState;
	}
}
