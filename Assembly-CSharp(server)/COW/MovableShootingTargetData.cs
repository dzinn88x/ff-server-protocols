using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200126E RID: 4718
	[Token(Token = "0x200126E")]
	public class MovableShootingTargetData : MonoBehaviour
	{
		// Token: 0x0600490F RID: 18703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490F")]
		[Address(RVA = "0x1A5DABC", Offset = "0x1A5DABC", VA = "0x7BBC25DABC")]
		public MovableShootingTargetData()
		{
		}

		// Token: 0x04007201 RID: 29185
		[Token(Token = "0x4007201")]
		[FieldOffset(Offset = "0x18")]
		public float MaxHP;

		// Token: 0x04007202 RID: 29186
		[Token(Token = "0x4007202")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector3> MovePointList;

		// Token: 0x04007203 RID: 29187
		[Token(Token = "0x4007203")]
		[FieldOffset(Offset = "0x28")]
		public float DelayToNextPoint;

		// Token: 0x04007204 RID: 29188
		[Token(Token = "0x4007204")]
		[FieldOffset(Offset = "0x2C")]
		public float DelayToRevive;

		// Token: 0x04007205 RID: 29189
		[Token(Token = "0x4007205")]
		[FieldOffset(Offset = "0x30")]
		public float ReviveTime;

		// Token: 0x04007206 RID: 29190
		[Token(Token = "0x4007206")]
		[FieldOffset(Offset = "0x34")]
		public float MoveSpeed;

		// Token: 0x04007207 RID: 29191
		[Token(Token = "0x4007207")]
		[FieldOffset(Offset = "0x38")]
		public string ModelResID;

		// Token: 0x04007208 RID: 29192
		[Token(Token = "0x4007208")]
		[FieldOffset(Offset = "0x40")]
		public Transform ModelContainer;

		// Token: 0x04007209 RID: 29193
		[Token(Token = "0x4007209")]
		[FieldOffset(Offset = "0x48")]
		public Transform HitColliderContainer;

		// Token: 0x0400720A RID: 29194
		[Token(Token = "0x400720A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WeaponGoodContainer;

		// Token: 0x0400720B RID: 29195
		[Token(Token = "0x400720B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WeaponNormalContainer;

		// Token: 0x0400720C RID: 29196
		[Token(Token = "0x400720C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject WeaponBadContainer;

		// Token: 0x0400720D RID: 29197
		[Token(Token = "0x400720D")]
		[FieldOffset(Offset = "0x68")]
		public bool CouldSelectedInShootingGame;

		// Token: 0x0400720E RID: 29198
		[Token(Token = "0x400720E")]
		[FieldOffset(Offset = "0x69")]
		public bool NeedAimAssist;
	}
}
