using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026E2 RID: 9954
	[Token(Token = "0x20026E2")]
	internal interface \u0081{oGdwC
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x0600CF4A RID: 53066
		[Token(Token = "0x17000DDC")]
		GameObject |YJAnla { [Token(Token = "0x600CF4A")] get; }

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600CF4B RID: 53067
		[Token(Token = "0x17000DDD")]
		Vector3 eInUyBA { [Token(Token = "0x600CF4B")] get; }

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600CF4C RID: 53068
		[Token(Token = "0x17000DDE")]
		Quaternion eDPRdo] { [Token(Token = "0x600CF4C")] get; }

		// Token: 0x0600CF4D RID: 53069
		[Token(Token = "0x600CF4D")]
		bool IsVisible();

		// Token: 0x0600CF4E RID: 53070
		[Token(Token = "0x600CF4E")]
		bool IsStreamerVisible();

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x0600CF4F RID: 53071
		[Token(Token = "0x17000DDF")]
		bool \u0080xliDYS { [Token(Token = "0x600CF4F")] get; }

		// Token: 0x0600CF50 RID: 53072
		[Token(Token = "0x600CF50")]
		uint GetAttackableID();

		// Token: 0x0600CF51 RID: 53073
		[Token(Token = "0x600CF51")]
		JDhUTU^ GetAttackableType();

		// Token: 0x0600CF52 RID: 53074
		[Token(Token = "0x600CF52")]
		float GetAttackableRadius();

		// Token: 0x0600CF53 RID: 53075
		[Token(Token = "0x600CF53")]
		Vector3 GetAttackableCenterWS();

		// Token: 0x0600CF54 RID: 53076
		[Token(Token = "0x600CF54")]
		Vector3 GetHitDamagePos();

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x0600CF55 RID: 53077
		// (set) Token: 0x0600CF56 RID: 53078
		[Token(Token = "0x17000DE0")]
		Collider sM\u007FxNNp { [Token(Token = "0x600CF55")] get; [Token(Token = "0x600CF56")] set; }

		// Token: 0x0600CF57 RID: 53079
		[Token(Token = "0x600CF57")]
		bool NeedAssit();

		// Token: 0x0600CF58 RID: 53080
		[Token(Token = "0x600CF58")]
		bool IsSameTeamWithPlayerID({QAb\u0082~u hVZ^Lay);

		// Token: 0x0600CF59 RID: 53081
		[Token(Token = "0x600CF59")]
		void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint ExBXjcs = 0U);

		// Token: 0x0600CF5A RID: 53082
		[Token(Token = "0x600CF5A")]
		void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int OhggZRq, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE);
	}
}
