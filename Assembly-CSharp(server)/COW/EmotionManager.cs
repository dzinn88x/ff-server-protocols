using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020011C0 RID: 4544
	[Token(Token = "0x20011C0")]
	internal class EmotionManager
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060046B8 RID: 18104 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060046B9 RID: 18105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event Action<AnimationClip> OnOverrideClip
		{
			[Token(Token = "0x60046B8")]
			[Address(RVA = "0x1B85E68", Offset = "0x1B85E68", VA = "0x7BBC385E68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA88", Offset = "0x113DA88")]
			add
			{
			}
			[Token(Token = "0x60046B9")]
			[Address(RVA = "0x1B85F54", Offset = "0x1B85F54", VA = "0x7BBC385F54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA98", Offset = "0x113DA98")]
			remove
			{
			}
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x1B86040", Offset = "0x1B86040", VA = "0x7BBC386040")]
		public EmotionManager(Animator animator)
		{
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x1B8606C", Offset = "0x1B8606C", VA = "0x7BBC38606C")]
		public void PlayEmotionAnimation(uint emotionID, bool isFemale)
		{
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x1B86594", Offset = "0x1B86594", VA = "0x7BBC386594")]
		public void PlayAnimClip(ResourceID animResId)
		{
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x1B86660", Offset = "0x1B86660", VA = "0x7BBC386660")]
		public static float GetEmotionAnimLength(EmoteData data, bool isFemale)
		{
			return 0f;
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x1B86734", Offset = "0x1B86734", VA = "0x7BBC386734")]
		public void StopEmotionAnimation()
		{
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x1B862F0", Offset = "0x1B862F0", VA = "0x7BBC3862F0")]
		private void SetOverrideAnim(AnimationClip clip)
		{
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x1B867DC", Offset = "0x1B867DC", VA = "0x7BBC3867DC")]
		private AnimationClip GetAnimClip(RuntimeAnimatorController controller, bool baseClip)
		{
			return null;
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x1B861A0", Offset = "0x1B861A0", VA = "0x7BBC3861A0")]
		private static AnimationClip LoadAnimClip(ResourceID id)
		{
			return null;
		}

		// Token: 0x04006DE6 RID: 28134
		[Token(Token = "0x4006DE6")]
		[FieldOffset(Offset = "0x10")]
		private Animator m_Animator;
	}
}
