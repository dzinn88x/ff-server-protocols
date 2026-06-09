using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012B0 RID: 4784
	[Token(Token = "0x20012B0")]
	internal class CommonMeshEffect : ReusableObject
	{
		// Token: 0x06004AEF RID: 19183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEF")]
		[Address(RVA = "0x15FBE88", Offset = "0x15FBE88", VA = "0x7BBBDFBE88")]
		private void Start()
		{
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x15FBF08", Offset = "0x15FBF08", VA = "0x7BBBDFBF08", Slot = "4")]
		public override void Prepare()
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x15FC00C", Offset = "0x15FC00C", VA = "0x7BBBDFC00C")]
		public void SetDelayDestoryTime(float t)
		{
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x15FC014", Offset = "0x15FC014", VA = "0x7BBBDFC014")]
		private void Update()
		{
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x15FC078", Offset = "0x15FC078", VA = "0x7BBBDFC078", Slot = "5")]
		protected override void DoRecycle()
		{
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x15FC0A0", Offset = "0x15FC0A0", VA = "0x7BBBDFC0A0")]
		public CommonMeshEffect()
		{
		}

		// Token: 0x04007321 RID: 29473
		[Token(Token = "0x4007321")]
		[FieldOffset(Offset = "0x2C")]
		public float DelayDestoryTime;

		// Token: 0x04007322 RID: 29474
		[Token(Token = "0x4007322")]
		[FieldOffset(Offset = "0x30")]
		private float m_GivenDelayDestoryTime;

		// Token: 0x04007323 RID: 29475
		[Token(Token = "0x4007323")]
		[FieldOffset(Offset = "0x34")]
		private float m_StartTime;

		// Token: 0x04007324 RID: 29476
		[Token(Token = "0x4007324")]
		[FieldOffset(Offset = "0x38")]
		private Animation[] m_Animations;

		// Token: 0x04007325 RID: 29477
		[Token(Token = "0x4007325")]
		[FieldOffset(Offset = "0x40")]
		private Animator[] m_Animators;
	}
}
