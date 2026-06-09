using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F9 RID: 8953
	[Token(Token = "0x20022F9")]
	internal class UIHudKilledView : UIBaseView
	{
		// Token: 0x0600C102 RID: 49410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C102")]
		[Address(RVA = "0x1C542FC", Offset = "0x1C542FC", VA = "0x7BBC4542FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C103")]
		[Address(RVA = "0x1C545DC", Offset = "0x1C545DC", VA = "0x7BBC4545DC")]
		public UIHudKilledView()
		{
		}

		// Token: 0x0400D7EC RID: 55276
		[Token(Token = "0x400D7EC")]
		[FieldOffset(Offset = "0x20")]
		public Animator NormalKill;

		// Token: 0x0400D7ED RID: 55277
		[Token(Token = "0x400D7ED")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NormalKillGO;

		// Token: 0x0400D7EE RID: 55278
		[Token(Token = "0x400D7EE")]
		[FieldOffset(Offset = "0x30")]
		public Animator HeadShotKill;

		// Token: 0x0400D7EF RID: 55279
		[Token(Token = "0x400D7EF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HeadShotKillGO;

		// Token: 0x0400D7F0 RID: 55280
		[Token(Token = "0x400D7F0")]
		[FieldOffset(Offset = "0x40")]
		public Animator Killed_AM_BlackBlood;

		// Token: 0x0400D7F1 RID: 55281
		[Token(Token = "0x400D7F1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Killed_AM_BlackBloodGO;

		// Token: 0x0400D7F2 RID: 55282
		[Token(Token = "0x400D7F2")]
		[FieldOffset(Offset = "0x50")]
		public Animator Killed_AM_HeadShot_BlackBlood;

		// Token: 0x0400D7F3 RID: 55283
		[Token(Token = "0x400D7F3")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Killed_AM_HeadShot_BlackBloodGO;

		// Token: 0x0400D7F4 RID: 55284
		[Token(Token = "0x400D7F4")]
		[FieldOffset(Offset = "0x60")]
		public Animator Killed_KnockDown;

		// Token: 0x0400D7F5 RID: 55285
		[Token(Token = "0x400D7F5")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Killed_KnockDownGO;
	}
}
