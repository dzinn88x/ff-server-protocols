using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x02002699 RID: 9881
	[Token(Token = "0x2002699")]
	internal class AIAnimEventHandle : MonoBehaviour
	{
		// Token: 0x0600CCAF RID: 52399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCAF")]
		[Address(RVA = "0x1B7D090", Offset = "0x1B7D090", VA = "0x7BBC37D090")]
		public void Register(NetworkAIPawn owner)
		{
		}

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB0")]
		[Address(RVA = "0x1B7D098", Offset = "0x1B7D098", VA = "0x7BBC37D098")]
		private void Start()
		{
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB1")]
		[Address(RVA = "0x1B7D0C0", Offset = "0x1B7D0C0", VA = "0x7BBC37D0C0")]
		private void PlayEventEffect(AnimationEvent evt)
		{
		}

		// Token: 0x0600CCB2 RID: 52402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB2")]
		[Address(RVA = "0x1B7D518", Offset = "0x1B7D518", VA = "0x7BBC37D518")]
		private void PlayEventSound(AnimationEvent evt)
		{
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB3")]
		[Address(RVA = "0x1B7D89C", Offset = "0x1B7D89C", VA = "0x7BBC37D89C")]
		private void PlayEventShadowEffect(AnimationEvent evt)
		{
		}

		// Token: 0x0600CCB4 RID: 52404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB4")]
		[Address(RVA = "0x1B7D9E8", Offset = "0x1B7D9E8", VA = "0x7BBC37D9E8")]
		private void EventSetModelVisibleState(AnimationEvent evt)
		{
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB5")]
		[Address(RVA = "0x1B7DAC8", Offset = "0x1B7DAC8", VA = "0x7BBC37DAC8")]
		private void EventSetColliderActiveState(AnimationEvent evt)
		{
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB6")]
		[Address(RVA = "0x1B7DBA8", Offset = "0x1B7DBA8", VA = "0x7BBC37DBA8")]
		public AIAnimEventHandle()
		{
		}

		// Token: 0x04010079 RID: 65657
		[Token(Token = "0x4010079")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_CacheTransform;

		// Token: 0x0401007A RID: 65658
		[Token(Token = "0x401007A")]
		[FieldOffset(Offset = "0x20")]
		private NetworkAIPawn m_Owner;
	}
}
