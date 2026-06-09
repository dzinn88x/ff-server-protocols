using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012BB RID: 4795
	[Token(Token = "0x20012BB")]
	public class VehicleResetPointManager : MonoBehaviour
	{
		// Token: 0x06004B3A RID: 19258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x17981D4", Offset = "0x17981D4", VA = "0x7BBBF981D4")]
		private void Start()
		{
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x1798390", Offset = "0x1798390", VA = "0x7BBBF98390")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x179854C", Offset = "0x179854C", VA = "0x7BBBF9854C")]
		private void OnLocalPlayerAdd(params object[] data)
		{
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x1798748", Offset = "0x1798748", VA = "0x7BBBF98748")]
		private void OnMiniGameClose(params object[] data)
		{
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x1798874", Offset = "0x1798874", VA = "0x7BBBF98874")]
		private void OnMiniGameStart(params object[] data)
		{
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x179892C", Offset = "0x179892C", VA = "0x7BBBF9892C")]
		private void OnVehicleReachPoint(params object[] data)
		{
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x1798C3C", Offset = "0x1798C3C", VA = "0x7BBBF98C3C")]
		public VehicleResetPointManager()
		{
		}

		// Token: 0x04007367 RID: 29543
		[Token(Token = "0x4007367")]
		[FieldOffset(Offset = "0x18")]
		public List<VehicleResetPos> VehicleResetPos;

		// Token: 0x04007368 RID: 29544
		[Token(Token = "0x4007368")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NextEffectGo;

		// Token: 0x04007369 RID: 29545
		[Token(Token = "0x4007369")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ArrowGo;

		// Token: 0x020012BC RID: 4796
		[Token(Token = "0x20012BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB088", Offset = "0x10EB088")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004B42 RID: 19266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B42")]
			[Address(RVA = "0x1798CA8", Offset = "0x1798CA8", VA = "0x7BBBF98CA8")]
			public <>c()
			{
			}

			// Token: 0x06004B43 RID: 19267 RVA: 0x000169C8 File Offset: 0x00014BC8
			[Token(Token = "0x6004B43")]
			[Address(RVA = "0x1798CB0", Offset = "0x1798CB0", VA = "0x7BBBF98CB0")]
			internal int <OnLocalPlayerAdd>b__5_0(VehicleResetPos x, VehicleResetPos y)
			{
				return 0;
			}

			// Token: 0x0400736A RID: 29546
			[Token(Token = "0x400736A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VehicleResetPointManager.<>c <>9;

			// Token: 0x0400736B RID: 29547
			[Token(Token = "0x400736B")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<VehicleResetPos> <>9__5_0;
		}
	}
}
