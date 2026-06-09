using System;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A87 RID: 10887
	[Token(Token = "0x2002A87")]
	internal interface xM\u0080cEzB
	{
		// Token: 0x0600EE96 RID: 61078
		[Token(Token = "0x600EE96")]
		GameObject GameObject();

		// Token: 0x0600EE97 RID: 61079
		[Token(Token = "0x600EE97")]
		void RegisterPlayer(Player RvYX}Cc, GameObject s\u0081cMn\u0081D);

		// Token: 0x0600EE98 RID: 61080
		[Token(Token = "0x600EE98")]
		void UnregisterPlayer();

		// Token: 0x0600EE99 RID: 61081
		[Token(Token = "0x600EE99")]
		Player GetPlayer();

		// Token: 0x0600EE9A RID: 61082
		[Token(Token = "0x600EE9A")]
		void UpdateSkill(float \u0081}x[tOF, float OsUltaA);

		// Token: 0x0600EE9B RID: 61083
		[Token(Token = "0x600EE9B")]
		void OnActSkillFinished([JfMv\u0082} Gbf\u0082KIG);

		// Token: 0x0600EE9C RID: 61084
		[Token(Token = "0x600EE9C")]
		void TryToCastActSkillByIndex(int z]|XnJH, bool IyAJv\u0082J);

		// Token: 0x0600EE9D RID: 61085
		[Token(Token = "0x600EE9D")]
		void PlaySkillPhaseAnim(string FjRemxs);

		// Token: 0x0600EE9E RID: 61086
		[Token(Token = "0x600EE9E")]
		void OnPlayerPlayAnim(AnimationID ^`QEUlJ);

		// Token: 0x0600EE9F RID: 61087
		[Token(Token = "0x600EE9F")]
		void SetColliderEnable(bool oDf^\u0081Hp, int `YX~Naf);

		// Token: 0x0600EEA0 RID: 61088
		[Token(Token = "0x600EEA0")]
		bool IsRunningSkill();

		// Token: 0x0600EEA1 RID: 61089
		[Token(Token = "0x600EEA1")]
		bool CheckSkillCanCast(int z]|XnJH);
	}
}
