using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C61 RID: 7265
	[Token(Token = "0x2001C61")]
	internal class PCAirTrailView : MonoBehaviour
	{
		// Token: 0x06009E53 RID: 40531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E53")]
		[Address(RVA = "0x203852C", Offset = "0x203852C", VA = "0x7BBC83852C")]
		protected void Awake()
		{
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E54")]
		[Address(RVA = "0x20385F8", Offset = "0x20385F8", VA = "0x7BBC8385F8")]
		public void Set1PEffect()
		{
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E55")]
		[Address(RVA = "0x2038650", Offset = "0x2038650", VA = "0x7BBC838650")]
		public void Set3PEffect()
		{
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E56")]
		[Address(RVA = "0x20386A8", Offset = "0x20386A8", VA = "0x7BBC8386A8")]
		public PCAirTrailView()
		{
		}

		// Token: 0x0400A48F RID: 42127
		[Token(Token = "0x400A48F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Particle1PGo;

		// Token: 0x0400A490 RID: 42128
		[Token(Token = "0x400A490")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Particle3PGo;

		// Token: 0x0400A491 RID: 42129
		[Token(Token = "0x400A491")]
		[FieldOffset(Offset = "0x28")]
		private Player player;
	}
}
