using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A4E RID: 10830
	[Token(Token = "0x2002A4E")]
	public class SamuraiEffectHelper : MonoBehaviour
	{
		// Token: 0x0600E8DF RID: 59615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8DF")]
		[Address(RVA = "0x173DBA4", Offset = "0x173DBA4", VA = "0x7BBBF3DBA4")]
		public void SetDefault()
		{
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E0")]
		[Address(RVA = "0x173DDD4", Offset = "0x173DDD4", VA = "0x7BBBF3DDD4")]
		public void OnPhaseChange(int }{ClHP~)
		{
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E1")]
		[Address(RVA = "0x173DF0C", Offset = "0x173DF0C", VA = "0x7BBBF3DF0C")]
		public void OnSkillPhaseEnter(yE^UZPY }{ClHP~, \u0081}\u0082XTuu Gbf\u0082KIG)
		{
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E2")]
		[Address(RVA = "0x173DBAC", Offset = "0x173DBAC", VA = "0x7BBBF3DBAC")]
		private void dLX^Bu\u0080(AIAttachEffects T{ZSc\u0081V)
		{
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E3")]
		[Address(RVA = "0x173E05C", Offset = "0x173E05C", VA = "0x7BBBF3E05C")]
		public SamuraiEffectHelper()
		{
		}

		// Token: 0x040113A7 RID: 70567
		[Token(Token = "0x40113A7")]
		[FieldOffset(Offset = "0x18")]
		public List<PhaseEffectInfo> phaseEffectInfos;

		// Token: 0x040113A8 RID: 70568
		[Token(Token = "0x40113A8")]
		[FieldOffset(Offset = "0x20")]
		public List<SkillEffectInfo> skillEffectsInfos;

		// Token: 0x040113A9 RID: 70569
		[Token(Token = "0x40113A9")]
		[FieldOffset(Offset = "0x28")]
		public AIAttachEffects initDefaultActiveEffects;
	}
}
