using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002818 RID: 10264
	[Token(Token = "0x2002818")]
	internal class BoxingMachine : AttackableEntity
	{
		// Token: 0x0600D820 RID: 55328 RVA: 0x0003BB38 File Offset: 0x00039D38
		[Token(Token = "0x600D820")]
		[Address(RVA = "0x17C8230", Offset = "0x17C8230", VA = "0x7BBBFC8230", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D821")]
		[Address(RVA = "0x17C8238", Offset = "0x17C8238", VA = "0x7BBBFC8238", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D822")]
		[Address(RVA = "0x17C8410", Offset = "0x17C8410", VA = "0x7BBBFC8410")]
		private void UPh]rxu()
		{
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D823")]
		[Address(RVA = "0x17C849C", Offset = "0x17C849C", VA = "0x7BBBFC849C")]
		private void dSzQC[e(ResourceID WohWctT, ResourceID vDjNXFh, Transform \u0082]VEIEU)
		{
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D824")]
		[Address(RVA = "0x17C8868", Offset = "0x17C8868", VA = "0x7BBBFC8868")]
		public BoxingMachine()
		{
		}

		// Token: 0x0401087D RID: 67709
		[Token(Token = "0x401087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject VFX_ScoreContainer;

		// Token: 0x0401087E RID: 67710
		[Token(Token = "0x401087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject VFX_HitContainer;
	}
}
