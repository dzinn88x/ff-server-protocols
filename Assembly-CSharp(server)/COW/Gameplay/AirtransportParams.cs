using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200280E RID: 10254
	[Token(Token = "0x200280E")]
	public class AirtransportParams : MonoBehaviour
	{
		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x0600D7E3 RID: 55267 RVA: 0x0003BA60 File Offset: 0x00039C60
		[Token(Token = "0x17000EB3")]
		public Vector3 dy{C^hN
		{
			[Token(Token = "0x600D7E3")]
			[Address(RVA = "0x18C0360", Offset = "0x18C0360", VA = "0x7BBC0C0360")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x0003BA78 File Offset: 0x00039C78
		[Token(Token = "0x17000EB4")]
		public Vector3 dJXh\u0081^T
		{
			[Token(Token = "0x600D7E4")]
			[Address(RVA = "0x18C0354", Offset = "0x18C0354", VA = "0x7BBC0C0354")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0003BA90 File Offset: 0x00039C90
		[Token(Token = "0x600D7E5")]
		[Address(RVA = "0x18C0984", Offset = "0x18C0984", VA = "0x7BBC0C0984")]
		public float GetEndJumpRatio({QAb\u0082~u BSUcaaw)
		{
			return 0f;
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E6")]
		[Address(RVA = "0x18C4338", Offset = "0x18C4338", VA = "0x7BBC0C4338")]
		public void SetStartPosition(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600D7E7 RID: 55271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E7")]
		[Address(RVA = "0x18C4344", Offset = "0x18C4344", VA = "0x7BBC0C4344")]
		public void SetEndPosition(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E8")]
		[Address(RVA = "0x18C46E0", Offset = "0x18C46E0", VA = "0x7BBC0C46E0")]
		public void Init(Vector3 Rv\u0080OJF{, Vector3 `Sq\u0082B[Z, int KHyh{dU, float jxPoDij, float jRuhGHh)
		{
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E9")]
		[Address(RVA = "0x18C48FC", Offset = "0x18C48FC", VA = "0x7BBC0C48FC")]
		public AirtransportParams()
		{
		}

		// Token: 0x0401084D RID: 67661
		[Token(Token = "0x401084D")]
		[FieldOffset(Offset = "0x18")]
		public Transform InnerSphere;

		// Token: 0x0401084E RID: 67662
		[Token(Token = "0x401084E")]
		[FieldOffset(Offset = "0x20")]
		public Transform OuterSphere;

		// Token: 0x0401084F RID: 67663
		[Token(Token = "0x401084F")]
		[FieldOffset(Offset = "0x28")]
		public float EndJumpDeltaMin;

		// Token: 0x04010850 RID: 67664
		[Token(Token = "0x4010850")]
		[FieldOffset(Offset = "0x2C")]
		public float StartJump;

		// Token: 0x04010851 RID: 67665
		[Token(Token = "0x4010851")]
		[FieldOffset(Offset = "0x30")]
		public float EndJump;

		// Token: 0x04010852 RID: 67666
		[Token(Token = "0x4010852")]
		[FieldOffset(Offset = "0x34")]
		public float EndJumpMin;

		// Token: 0x04010853 RID: 67667
		[Token(Token = "0x4010853")]
		[FieldOffset(Offset = "0x38")]
		public float EndJumpMax;

		// Token: 0x04010854 RID: 67668
		[Token(Token = "0x4010854")]
		[FieldOffset(Offset = "0x3C")]
		public float Duration;

		// Token: 0x04010855 RID: 67669
		[Token(Token = "0x4010855")]
		[FieldOffset(Offset = "0x40")]
		public AirtransportParams.<<EMPTY_NAME>> MatchType;

		// Token: 0x04010856 RID: 67670
		[Token(Token = "0x4010856")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<{QAb\u0082~u, float> U|XofRY;

		// Token: 0x04010857 RID: 67671
		[Token(Token = "0x4010857")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 O}UuyE{;

		// Token: 0x04010858 RID: 67672
		[Token(Token = "0x4010858")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 Lkww\u0081Jp;

		// Token: 0x0200280F RID: 10255
		[Token(Token = "0x200280F")]
		public enum <<EMPTY_NAME>>
		{
			// Token: 0x0401085A RID: 67674
			[Token(Token = "0x401085A")]
			RankedMatch,
			// Token: 0x0401085B RID: 67675
			[Token(Token = "0x401085B")]
			CasualMatchNormal,
			// Token: 0x0401085C RID: 67676
			[Token(Token = "0x401085C")]
			CasualMatchNewbie
		}
	}
}
