using System;
using COW.GamePlay;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200160B RID: 5643
	[Token(Token = "0x200160B")]
	public class ReplayEventBtnView : MonoBehaviour
	{
		// Token: 0x06006527 RID: 25895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006527")]
		[Address(RVA = "0x1759CA0", Offset = "0x1759CA0", VA = "0x7BBBF59CA0")]
		public void Init(\u0081fXogCG evt, uint id, float time, string info = "", uint color = 4294967295U)
		{
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006528")]
		[Address(RVA = "0x1759E8C", Offset = "0x1759E8C", VA = "0x7BBBF59E8C")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006529")]
		[Address(RVA = "0x1759FAC", Offset = "0x1759FAC", VA = "0x7BBBF59FAC")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x0001CF38 File Offset: 0x0001B138
		[Token(Token = "0x600652A")]
		[Address(RVA = "0x1759FFC", Offset = "0x1759FFC", VA = "0x7BBBF59FFC")]
		public \u0081fXogCG GetReplayEvent()
		{
			return (\u0081fXogCG)0U;
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652B")]
		[Address(RVA = "0x175A004", Offset = "0x175A004", VA = "0x7BBBF5A004")]
		public void SetActive(bool free, {QAb\u0082~u id)
		{
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652C")]
		[Address(RVA = "0x175A164", Offset = "0x175A164", VA = "0x7BBBF5A164")]
		public ReplayEventBtnView()
		{
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652D")]
		[Address(RVA = "0x175A16C", Offset = "0x175A16C", VA = "0x7BBBF5A16C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114050C", Offset = "0x114050C")]
		private void <OnBtnClick>b__6_0()
		{
		}

		// Token: 0x04008372 RID: 33650
		[Token(Token = "0x4008372")]
		[FieldOffset(Offset = "0x18")]
		public UIButton Button;

		// Token: 0x04008373 RID: 33651
		[Token(Token = "0x4008373")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Tips;

		// Token: 0x04008374 RID: 33652
		[Token(Token = "0x4008374")]
		[FieldOffset(Offset = "0x28")]
		private \u0081fXogCG m_ReplayEvent;

		// Token: 0x04008375 RID: 33653
		[Token(Token = "0x4008375")]
		[FieldOffset(Offset = "0x30")]
		private {QAb\u0082~u m_PlayerID;

		// Token: 0x04008376 RID: 33654
		[Token(Token = "0x4008376")]
		[FieldOffset(Offset = "0x48")]
		private float m_Time;
	}
}
