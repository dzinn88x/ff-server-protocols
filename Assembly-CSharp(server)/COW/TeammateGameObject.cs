using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C5D RID: 7261
	[Token(Token = "0x2001C5D")]
	public class TeammateGameObject
	{
		// Token: 0x06009E15 RID: 40469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E15")]
		[Address(RVA = "0x1B46730", Offset = "0x1B46730", VA = "0x7BBC346730")]
		public TeammateGameObject(GameObject _teammate)
		{
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x00029568 File Offset: 0x00027768
		[Token(Token = "0x6009E16")]
		[Address(RVA = "0x1B46E3C", Offset = "0x1B46E3C", VA = "0x7BBC346E3C")]
		public ETeammateState GetState()
		{
			return ETeammateState.eNone;
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E17")]
		[Address(RVA = "0x1B46A08", Offset = "0x1B46A08", VA = "0x7BBC346A08")]
		public void SetState(ETeammateState nextState, [Optional] List<object> argList)
		{
		}

		// Token: 0x0400A45C RID: 42076
		[Token(Token = "0x400A45C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject teammate;

		// Token: 0x0400A45D RID: 42077
		[Token(Token = "0x400A45D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject id;

		// Token: 0x0400A45E RID: 42078
		[Token(Token = "0x400A45E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject direction;

		// Token: 0x0400A45F RID: 42079
		[Token(Token = "0x400A45F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject knockdown;

		// Token: 0x0400A460 RID: 42080
		[Token(Token = "0x400A460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject dead;

		// Token: 0x0400A461 RID: 42081
		[Token(Token = "0x400A461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject vehicle;

		// Token: 0x0400A462 RID: 42082
		[Token(Token = "0x400A462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TweenAlpha Firing_Tween;

		// Token: 0x0400A463 RID: 42083
		[Token(Token = "0x400A463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ETeammateState m_CurrentState;
	}
}
