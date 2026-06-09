using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001085 RID: 4229
	[Token(Token = "0x2001085")]
	internal class ArenaPlayerManager : MonoBehaviour
	{
		// Token: 0x060040E1 RID: 16609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x15515C4", Offset = "0x15515C4", VA = "0x7BBBD515C4")]
		protected void Start()
		{
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x15516A4", Offset = "0x15516A4", VA = "0x7BBBD516A4")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x1551780", Offset = "0x1551780", VA = "0x7BBBD51780")]
		private void OnUmaDCReady(params object[] data)
		{
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x1551798", Offset = "0x1551798", VA = "0x7BBBD51798")]
		private void CreatePlayers()
		{
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x1551CF8", Offset = "0x1551CF8", VA = "0x7BBBD51CF8")]
		public ArenaPlayerManager()
		{
		}

		// Token: 0x04005059 RID: 20569
		[Token(Token = "0x4005059")]
		[FieldOffset(Offset = "0x18")]
		private bool m_Created;

		// Token: 0x0400505A RID: 20570
		[Token(Token = "0x400505A")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] m_SpawnPoints;
	}
}
