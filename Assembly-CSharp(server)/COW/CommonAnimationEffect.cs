using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012AE RID: 4782
	[Token(Token = "0x20012AE")]
	internal class CommonAnimationEffect : ReusableObject
	{
		// Token: 0x06004AEA RID: 19178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x15FBA10", Offset = "0x15FBA10", VA = "0x7BBBDFBA10")]
		private void Awake()
		{
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x15FBAB8", Offset = "0x15FBAB8", VA = "0x7BBBDFBAB8")]
		public void Play()
		{
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x15FBD2C", Offset = "0x15FBD2C", VA = "0x7BBBDFBD2C")]
		public CommonAnimationEffect()
		{
		}

		// Token: 0x0400731E RID: 29470
		[Token(Token = "0x400731E")]
		[FieldOffset(Offset = "0x30")]
		protected Animator[] m_Animators;

		// Token: 0x0400731F RID: 29471
		[Token(Token = "0x400731F")]
		[FieldOffset(Offset = "0x38")]
		protected Animation[] m_Animations;
	}
}
