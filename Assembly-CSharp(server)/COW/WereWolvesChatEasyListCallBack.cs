using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019A1 RID: 6561
	[Token(Token = "0x20019A1")]
	public class WereWolvesChatEasyListCallBack : IEasyList
	{
		// Token: 0x06008640 RID: 34368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008640")]
		[Address(RVA = "0x23DF260", Offset = "0x23DF260", VA = "0x7BBCBDF260")]
		public WereWolvesChatEasyListCallBack(UIHudWereWolvesVoteController controller, Transform content)
		{
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008641")]
		[Address(RVA = "0x23DF298", Offset = "0x23DF298", VA = "0x7BBCBDF298", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008642")]
		[Address(RVA = "0x23DF2CC", Offset = "0x23DF2CC", VA = "0x7BBCBDF2CC", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x04009574 RID: 38260
		[Token(Token = "0x4009574")]
		[FieldOffset(Offset = "0x10")]
		private Transform m_content;

		// Token: 0x04009575 RID: 38261
		[Token(Token = "0x4009575")]
		[FieldOffset(Offset = "0x18")]
		public UIHudWereWolvesVoteController m_controller;
	}
}
