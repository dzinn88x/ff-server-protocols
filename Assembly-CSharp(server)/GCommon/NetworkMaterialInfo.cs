using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F39 RID: 3897
	[Token(Token = "0x2000F39")]
	public class NetworkMaterialInfo
	{
		// Token: 0x060037DA RID: 14298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037DA")]
		[Address(RVA = "0x2466E1C", Offset = "0x2466E1C", VA = "0x7BBCC66E1C")]
		public NetworkMaterialInfo(Material mat, Vector2 size)
		{
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x60037DB")]
		[Address(RVA = "0x2466EB0", Offset = "0x2466EB0", VA = "0x7BBCC66EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00011478 File Offset: 0x0000F678
		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x2466EB8", Offset = "0x2466EB8", VA = "0x7BBCC66EB8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04004A40 RID: 19008
		[Token(Token = "0x4004A40")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 TextureSize;

		// Token: 0x04004A41 RID: 19009
		[Token(Token = "0x4004A41")]
		[FieldOffset(Offset = "0x18")]
		public Material TargetMaterial;
	}
}
