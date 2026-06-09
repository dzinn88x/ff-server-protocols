using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x02001078 RID: 4216
	[Token(Token = "0x2001078")]
	public class ConstForce : MonoBehaviour
	{
		// Token: 0x0600407B RID: 16507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x249A178", Offset = "0x249A178", VA = "0x7BBCC9A178")]
		private void Start()
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x249A17C", Offset = "0x249A17C", VA = "0x7BBCC9A17C")]
		private void Update()
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x249A2D4", Offset = "0x249A2D4", VA = "0x7BBCC9A2D4")]
		public ConstForce()
		{
		}

		// Token: 0x04005013 RID: 20499
		[Token(Token = "0x4005013")]
		[FieldOffset(Offset = "0x18")]
		public List<SmokePlume> trails;

		// Token: 0x04005014 RID: 20500
		[Token(Token = "0x4005014")]
		[FieldOffset(Offset = "0x20")]
		public float speed;
	}
}
