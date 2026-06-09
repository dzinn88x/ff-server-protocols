using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028AC RID: 10412
	[Token(Token = "0x20028AC")]
	public class LevelStropShelfManager : MonoBehaviour
	{
		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600DCB0 RID: 56496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F06")]
		public static LevelStropShelfManager GHG[JH\u0080
		{
			[Token(Token = "0x600DCB0")]
			[Address(RVA = "0x1D3FC14", Offset = "0x1D3FC14", VA = "0x7BBC53FC14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DCB1 RID: 56497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB1")]
		[Address(RVA = "0x1D3FC7C", Offset = "0x1D3FC7C", VA = "0x7BBC53FC7C")]
		private void Awake()
		{
		}

		// Token: 0x0600DCB2 RID: 56498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB2")]
		[Address(RVA = "0x1D3FE8C", Offset = "0x1D3FE8C", VA = "0x7BBC53FE8C")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB3")]
		[Address(RVA = "0x1D3FEF4", Offset = "0x1D3FEF4", VA = "0x7BBC53FEF4")]
		public static void AssignStropShelfID(LevelStropShelfManager iMj\u007FkR~)
		{
		}

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB4")]
		[Address(RVA = "0x1D40120", Offset = "0x1D40120", VA = "0x7BBC540120")]
		public LevelStropShelfManager()
		{
		}

		// Token: 0x04010BD6 RID: 68566
		[Token(Token = "0x4010BD6")]
		[FieldOffset(Offset = "0x0")]
		private static LevelStropShelfManager zM\u0080cP~];

		// Token: 0x04010BD7 RID: 68567
		[Token(Token = "0x4010BD7")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Dictionary<int, LevelStropShelf> StropShelfs;

		// Token: 0x04010BD8 RID: 68568
		[Token(Token = "0x4010BD8")]
		[FieldOffset(Offset = "0x20")]
		public List<LevelStrop> Strops;
	}
}
