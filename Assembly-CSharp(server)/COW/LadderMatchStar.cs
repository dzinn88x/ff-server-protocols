using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015E0 RID: 5600
	[Token(Token = "0x20015E0")]
	public class LadderMatchStar
	{
		// Token: 0x06006355 RID: 25429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006355")]
		[Address(RVA = "0x13FDE6C", Offset = "0x13FDE6C", VA = "0x7BBBBFDE6C")]
		public void InitStar(GameObject star, Transform parent)
		{
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006356")]
		[Address(RVA = "0x13FE07C", Offset = "0x13FE07C", VA = "0x7BBBBFE07C")]
		public void SetStarActive(bool enable)
		{
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006357")]
		[Address(RVA = "0x13FE0B0", Offset = "0x13FE0B0", VA = "0x7BBBBFE0B0")]
		public void SetStarOn()
		{
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006358")]
		[Address(RVA = "0x13FE174", Offset = "0x13FE174", VA = "0x7BBBBFE174")]
		public void SetStarOff()
		{
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006359")]
		[Address(RVA = "0x13FE238", Offset = "0x13FE238", VA = "0x7BBBBFE238")]
		public Animation GetStarAnimation()
		{
			return null;
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635A")]
		[Address(RVA = "0x13FE240", Offset = "0x13FE240", VA = "0x7BBBBFE240")]
		public LadderMatchStar()
		{
		}

		// Token: 0x04008207 RID: 33287
		[Token(Token = "0x4008207")]
		public const string ANIMATION_GAINSTAR = "UILadderCSMatchStarUp";

		// Token: 0x04008208 RID: 33288
		[Token(Token = "0x4008208")]
		public const string ANIMATION_LOSESTAR = "UILadderCSMatchStarLose";

		// Token: 0x04008209 RID: 33289
		[Token(Token = "0x4008209")]
		[FieldOffset(Offset = "0x10")]
		private GameObject Star;

		// Token: 0x0400820A RID: 33290
		[Token(Token = "0x400820A")]
		[FieldOffset(Offset = "0x18")]
		private Animation StarAnimation;
	}
}
