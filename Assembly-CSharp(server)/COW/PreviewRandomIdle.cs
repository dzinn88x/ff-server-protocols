using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012A0 RID: 4768
	[Token(Token = "0x20012A0")]
	public class PreviewRandomIdle : MonoBehaviour
	{
		// Token: 0x06004A93 RID: 19091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x1749EB0", Offset = "0x1749EB0", VA = "0x7BBBF49EB0")]
		private void Awake()
		{
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x1749F4C", Offset = "0x1749F4C", VA = "0x7BBBF49F4C")]
		private void Update()
		{
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x174A104", Offset = "0x174A104", VA = "0x7BBBF4A104")]
		public void StartRecordIdle()
		{
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A96")]
		[Address(RVA = "0x174A114", Offset = "0x174A114", VA = "0x7BBBF4A114")]
		public void ResetRecord()
		{
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A97")]
		[Address(RVA = "0x1749FB4", Offset = "0x1749FB4", VA = "0x7BBBF49FB4")]
		private void UpdatePlayerAnimator()
		{
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x174A120", Offset = "0x174A120", VA = "0x7BBBF4A120")]
		public PreviewRandomIdle()
		{
		}

		// Token: 0x040072E0 RID: 29408
		[Token(Token = "0x40072E0")]
		[FieldOffset(Offset = "0x18")]
		public List<Animator> m_PlayerAnimatorList;

		// Token: 0x040072E1 RID: 29409
		[Token(Token = "0x40072E1")]
		[FieldOffset(Offset = "0x20")]
		public AnimationClip IdleAnim;

		// Token: 0x040072E2 RID: 29410
		[Token(Token = "0x40072E2")]
		[FieldOffset(Offset = "0x28")]
		private float ActionTime;

		// Token: 0x040072E3 RID: 29411
		[Token(Token = "0x40072E3")]
		[FieldOffset(Offset = "0x2C")]
		private float RealTime;

		// Token: 0x040072E4 RID: 29412
		[Token(Token = "0x40072E4")]
		[FieldOffset(Offset = "0x30")]
		private bool StartIdle;
	}
}
