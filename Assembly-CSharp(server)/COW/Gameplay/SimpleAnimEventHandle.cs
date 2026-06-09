using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x020026A4 RID: 9892
	[Token(Token = "0x20026A4")]
	internal class SimpleAnimEventHandle : MonoBehaviour
	{
		// Token: 0x0600CD00 RID: 52480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD00")]
		[Address(RVA = "0x1D8C8FC", Offset = "0x1D8C8FC", VA = "0x7BBC58C8FC")]
		private void Start()
		{
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD01")]
		[Address(RVA = "0x1D8C964", Offset = "0x1D8C964", VA = "0x7BBC58C964")]
		private void OnTransformParentChanged()
		{
		}

		// Token: 0x0600CD02 RID: 52482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD02")]
		[Address(RVA = "0x1D8C9BC", Offset = "0x1D8C9BC", VA = "0x7BBC58C9BC")]
		private void PlayEventEffect(AnimationEvent evt)
		{
		}

		// Token: 0x0600CD03 RID: 52483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD03")]
		[Address(RVA = "0x1D8CEDC", Offset = "0x1D8CEDC", VA = "0x7BBC58CEDC")]
		private void PlayEventSound(AnimationEvent evt)
		{
		}

		// Token: 0x0600CD04 RID: 52484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD04")]
		[Address(RVA = "0x1D8D304", Offset = "0x1D8D304", VA = "0x7BBC58D304")]
		public void PlayShakeCamera(AnimationEvent evt)
		{
		}

		// Token: 0x0600CD05 RID: 52485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD05")]
		[Address(RVA = "0x1D8D6A4", Offset = "0x1D8D6A4", VA = "0x7BBC58D6A4")]
		public SimpleAnimEventHandle()
		{
		}

		// Token: 0x040100AD RID: 65709
		[Token(Token = "0x40100AD")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_CacheTransform;

		// Token: 0x040100AE RID: 65710
		[Token(Token = "0x40100AE")]
		[FieldOffset(Offset = "0x20")]
		private ActionSkillPawn ownerSkillPawn;
	}
}
