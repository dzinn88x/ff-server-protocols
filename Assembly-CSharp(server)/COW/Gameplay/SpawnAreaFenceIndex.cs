using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B22 RID: 11042
	[Token(Token = "0x2002B22")]
	public class SpawnAreaFenceIndex : MonoBehaviour
	{
		// Token: 0x0600F284 RID: 62084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F284")]
		[Address(RVA = "0x16C4C24", Offset = "0x16C4C24", VA = "0x7BBBEC4C24")]
		private void OnEnable()
		{
		}

		// Token: 0x0600F285 RID: 62085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F285")]
		[Address(RVA = "0x16C4D24", Offset = "0x16C4D24", VA = "0x7BBBEC4D24")]
		private void OnDisable()
		{
		}

		// Token: 0x0600F286 RID: 62086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F286")]
		[Address(RVA = "0x16C4D28", Offset = "0x16C4D28", VA = "0x7BBBEC4D28")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600F287 RID: 62087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F287")]
		[Address(RVA = "0x16C4DF8", Offset = "0x16C4DF8", VA = "0x7BBBEC4DF8")]
		public void SetColliderAndEffectStatus(bool xZCrsr[)
		{
		}

		// Token: 0x0600F288 RID: 62088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F288")]
		[Address(RVA = "0x16C4F4C", Offset = "0x16C4F4C", VA = "0x7BBBEC4F4C")]
		public SpawnAreaFenceIndex()
		{
		}

		// Token: 0x0401180B RID: 71691
		[Token(Token = "0x401180B")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x0401180C RID: 71692
		[Token(Token = "0x401180C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Col;

		// Token: 0x0401180D RID: 71693
		[Token(Token = "0x401180D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject EffectLow;

		// Token: 0x0401180E RID: 71694
		[Token(Token = "0x401180E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EffectHigh;
	}
}
