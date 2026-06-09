using System;
using COW.GamePlay;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C6D RID: 7277
	[Token(Token = "0x2001C6D")]
	internal class UIHudHyakkiTeammateItem : MonoBehaviour
	{
		// Token: 0x06009EA1 RID: 40609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA1")]
		[Address(RVA = "0x19801E8", Offset = "0x19801E8", VA = "0x7BBC1801E8")]
		public void Show(bool v)
		{
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA2")]
		[Address(RVA = "0x1980224", Offset = "0x1980224", VA = "0x7BBC180224")]
		public void InitInfo(Player p)
		{
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA3")]
		[Address(RVA = "0x1980FB8", Offset = "0x1980FB8", VA = "0x7BBC180FB8")]
		public void InitWithPlayerInfo(^|dlTwk playerInfo)
		{
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA4")]
		[Address(RVA = "0x1980CA8", Offset = "0x1980CA8", VA = "0x7BBC180CA8")]
		public void SetVoiceVisible(bool flag)
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA5")]
		[Address(RVA = "0x1980F68", Offset = "0x1980F68", VA = "0x7BBC180F68")]
		public void SetMarkShow(bool show)
		{
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA6")]
		[Address(RVA = "0x1980CE0", Offset = "0x1980CE0", VA = "0x7BBC180CE0")]
		public void SetTeammateState(ETeammateState nextState)
		{
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA7")]
		[Address(RVA = "0x1980BC8", Offset = "0x1980BC8", VA = "0x7BBC180BC8")]
		public void SetDisconnected(bool disconnected)
		{
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA8")]
		[Address(RVA = "0x19809F0", Offset = "0x19809F0", VA = "0x7BBC1809F0")]
		public void OnHPChanged(Player p)
		{
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EA9")]
		[Address(RVA = "0x19812AC", Offset = "0x19812AC", VA = "0x7BBC1812AC")]
		private void OnReviveBtnClick()
		{
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EAA")]
		[Address(RVA = "0x19813E0", Offset = "0x19813E0", VA = "0x7BBC1813E0")]
		public void UpdateDamage(uint damage)
		{
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009EAB")]
		[Address(RVA = "0x198141C", Offset = "0x198141C", VA = "0x7BBC18141C")]
		private string ConvertDamageToString(uint damage)
		{
			return null;
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EAC")]
		[Address(RVA = "0x19815E0", Offset = "0x19815E0", VA = "0x7BBC1815E0")]
		public void UpdateBuybackAvaliable(bool enable)
		{
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EAD")]
		[Address(RVA = "0x198161C", Offset = "0x198161C", VA = "0x7BBC18161C")]
		public void UpdateCostLabel(int cost)
		{
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x00029748 File Offset: 0x00027948
		[Token(Token = "0x6009EAE")]
		[Address(RVA = "0x1980900", Offset = "0x1980900", VA = "0x7BBC180900")]
		private bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EAF")]
		[Address(RVA = "0x1981670", Offset = "0x1981670", VA = "0x7BBC181670")]
		public void UpdateDamageShow(bool isShow)
		{
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EB0")]
		[Address(RVA = "0x19816C0", Offset = "0x19816C0", VA = "0x7BBC1816C0")]
		public UIHudHyakkiTeammateItem()
		{
		}

		// Token: 0x0400A506 RID: 42246
		[Token(Token = "0x400A506")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Name;

		// Token: 0x0400A507 RID: 42247
		[Token(Token = "0x400A507")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HPBarGO;

		// Token: 0x0400A508 RID: 42248
		[Token(Token = "0x400A508")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HP;

		// Token: 0x0400A509 RID: 42249
		[Token(Token = "0x400A509")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Mark;

		// Token: 0x0400A50A RID: 42250
		[Token(Token = "0x400A50A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject KillerGO;

		// Token: 0x0400A50B RID: 42251
		[Token(Token = "0x400A50B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TeamIndex;

		// Token: 0x0400A50C RID: 42252
		[Token(Token = "0x400A50C")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Knockdown;

		// Token: 0x0400A50D RID: 42253
		[Token(Token = "0x400A50D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Offline;

		// Token: 0x0400A50E RID: 42254
		[Token(Token = "0x400A50E")]
		[FieldOffset(Offset = "0x58")]
		public UISprite DisFlag;

		// Token: 0x0400A50F RID: 42255
		[Token(Token = "0x400A50F")]
		[FieldOffset(Offset = "0x60")]
		public UISprite Vehicle;

		// Token: 0x0400A510 RID: 42256
		[Token(Token = "0x400A510")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VoiceGO;

		// Token: 0x0400A511 RID: 42257
		[Token(Token = "0x400A511")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Damage;

		// Token: 0x0400A512 RID: 42258
		[Token(Token = "0x400A512")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ReviveBtn;

		// Token: 0x0400A513 RID: 42259
		[Token(Token = "0x400A513")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ReviveLabel;

		// Token: 0x0400A514 RID: 42260
		[Token(Token = "0x400A514")]
		[FieldOffset(Offset = "0x88")]
		public UISprite Self;

		// Token: 0x0400A515 RID: 42261
		[Token(Token = "0x400A515")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public int TeamIndexNum;

		// Token: 0x0400A516 RID: 42262
		[Token(Token = "0x400A516")]
		[FieldOffset(Offset = "0x94")]
		private ETeammateState m_CurrentState;

		// Token: 0x0400A517 RID: 42263
		[Token(Token = "0x400A517")]
		[FieldOffset(Offset = "0x98")]
		private {QAb\u0082~u m_BindPlayerID;
	}
}
