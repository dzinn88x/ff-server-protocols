using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200274F RID: 10063
	[Token(Token = "0x200274F")]
	[Serializable]
	public class VehicleUpgradeSetting
	{
		// Token: 0x0600D22B RID: 53803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D22B")]
		[Address(RVA = "0x1496274", Offset = "0x1496274", VA = "0x7BBBC96274")]
		public VehicleUpgradeSetting()
		{
		}

		// Token: 0x040105A1 RID: 66977
		[Token(Token = "0x40105A1")]
		[FieldOffset(Offset = "0x10")]
		public GameObject Model;

		// Token: 0x040105A2 RID: 66978
		[Token(Token = "0x40105A2")]
		[FieldOffset(Offset = "0x18")]
		public Transform EffectAnchor;

		// Token: 0x040105A3 RID: 66979
		[Token(Token = "0x40105A3")]
		[FieldOffset(Offset = "0x20")]
		public string EffectResID;

		// Token: 0x040105A4 RID: 66980
		[Token(Token = "0x40105A4")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID ResID;

		// Token: 0x040105A5 RID: 66981
		[Token(Token = "0x40105A5")]
		[FieldOffset(Offset = "0x30")]
		public string SoundResID;

		// Token: 0x040105A6 RID: 66982
		[Token(Token = "0x40105A6")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID SoundRes;
	}
}
