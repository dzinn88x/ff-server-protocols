using System;
using COW.GamePlay;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001613 RID: 5651
	[Token(Token = "0x2001613")]
	internal class UISPHudTeammateItem : UIHudTeammateItem
	{
		// Token: 0x06006553 RID: 25939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006553")]
		[Address(RVA = "0x1EFB958", Offset = "0x1EFB958", VA = "0x7BBC6FB958")]
		private void Awake()
		{
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006554")]
		[Address(RVA = "0x1EFB9B4", Offset = "0x1EFB9B4", VA = "0x7BBC6FB9B4")]
		public void UpdatePlayerKillCount(uint count)
		{
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006555")]
		[Address(RVA = "0x1EFBA08", Offset = "0x1EFBA08", VA = "0x7BBC6FBA08", Slot = "4")]
		public override void InitInfo(Player p)
		{
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006556")]
		[Address(RVA = "0x1EFC568", Offset = "0x1EFC568", VA = "0x7BBC6FC568", Slot = "5")]
		public override void InitInfo(cfSip\u007Fz.^|dlTwk p)
		{
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006557")]
		[Address(RVA = "0x1EFC78C", Offset = "0x1EFC78C", VA = "0x7BBC6FC78C", Slot = "6")]
		public override void InitWithPlayerInfo(^|dlTwk playerInfo)
		{
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006558")]
		[Address(RVA = "0x1EFBC9C", Offset = "0x1EFBC9C", VA = "0x7BBC6FBC9C")]
		public void UpdateWeaponInfo(Player p)
		{
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006559")]
		[Address(RVA = "0x1EFC3D8", Offset = "0x1EFC3D8", VA = "0x7BBC6FC3D8")]
		private void InitFiring(Player p)
		{
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655A")]
		[Address(RVA = "0x1EFC930", Offset = "0x1EFC930", VA = "0x7BBC6FC930")]
		public void SetFireEffect(bool firing)
		{
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655B")]
		[Address(RVA = "0x1EFC9AC", Offset = "0x1EFC9AC", VA = "0x7BBC6FC9AC")]
		public void OnKnockDownStateChanged(bool isDown)
		{
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655C")]
		[Address(RVA = "0x1EFCA70", Offset = "0x1EFCA70", VA = "0x7BBC6FCA70", Slot = "7")]
		public override void OnHPChanged(Player p)
		{
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
		[Token(Token = "0x600655D")]
		[Address(RVA = "0x1EFCA34", Offset = "0x1EFCA34", VA = "0x7BBC6FCA34")]
		private Color GetHPColor(bool isDieing)
		{
			return default(Color);
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655E")]
		[Address(RVA = "0x1EFCC5C", Offset = "0x1EFCC5C", VA = "0x7BBC6FCC5C")]
		public void OnPlayerDead()
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655F")]
		[Address(RVA = "0x1EFCCB8", Offset = "0x1EFCCB8", VA = "0x7BBC6FCCB8")]
		public void OnPlayerRevive()
		{
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006560")]
		[Address(RVA = "0x1EFC4E0", Offset = "0x1EFC4E0", VA = "0x7BBC6FC4E0")]
		public void SetNameColor(bool isDead)
		{
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006561")]
		[Address(RVA = "0x1EFCD14", Offset = "0x1EFCD14", VA = "0x7BBC6FCD14")]
		public UISPHudTeammateItem()
		{
		}

		// Token: 0x040083B6 RID: 33718
		[Token(Token = "0x40083B6")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite WeaponIcon;

		// Token: 0x040083B7 RID: 33719
		[Token(Token = "0x40083B7")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject FiringGo;

		// Token: 0x040083B8 RID: 33720
		[Token(Token = "0x40083B8")]
		[FieldOffset(Offset = "0x100")]
		public UILabel killCount;

		// Token: 0x040083B9 RID: 33721
		[Token(Token = "0x40083B9")]
		[FieldOffset(Offset = "0x108")]
		private int weapon_origin_width;

		// Token: 0x040083BA RID: 33722
		[Token(Token = "0x40083BA")]
		[FieldOffset(Offset = "0x10C")]
		private int weapon_origin_height;

		// Token: 0x040083BB RID: 33723
		[Token(Token = "0x40083BB")]
		[FieldOffset(Offset = "0x110")]
		private readonly Color HP_COLOR_NORMAL;

		// Token: 0x040083BC RID: 33724
		[Token(Token = "0x40083BC")]
		[FieldOffset(Offset = "0x120")]
		private readonly Color HP_COLOR_KNOCK_DOWN;

		// Token: 0x040083BD RID: 33725
		[Token(Token = "0x40083BD")]
		[FieldOffset(Offset = "0x130")]
		private readonly Color NAME_COLOR_NORMAL;

		// Token: 0x040083BE RID: 33726
		[Token(Token = "0x40083BE")]
		[FieldOffset(Offset = "0x140")]
		private readonly Color NAME_COLOR_DEAD;
	}
}
