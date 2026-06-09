using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013DA RID: 5082
	[Token(Token = "0x20013DA")]
	public class UIActivityActivenessRewardDescription : MonoBehaviour
	{
		// Token: 0x06005360 RID: 21344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005360")]
		[Address(RVA = "0x1A436F4", Offset = "0x1A436F4", VA = "0x7BBC2436F4")]
		private void Start()
		{
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005361")]
		[Address(RVA = "0x1A41EB8", Offset = "0x1A41EB8", VA = "0x7BBC241EB8")]
		public void SetData(ActivenessReward reward)
		{
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005362")]
		[Address(RVA = "0x1A42B28", Offset = "0x1A42B28", VA = "0x7BBC242B28")]
		public void SetButtonState()
		{
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005363")]
		[Address(RVA = "0x1A437A8", Offset = "0x1A437A8", VA = "0x7BBC2437A8")]
		private void OnOperate()
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005364")]
		[Address(RVA = "0x1A42B20", Offset = "0x1A42B20", VA = "0x7BBC242B20")]
		public ActivenessReward GetData()
		{
			return null;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005365")]
		[Address(RVA = "0x1A440FC", Offset = "0x1A440FC", VA = "0x7BBC2440FC")]
		public UIActivityActivenessRewardDescription()
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005366")]
		[Address(RVA = "0x1A44154", Offset = "0x1A44154", VA = "0x7BBC244154")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E4C0", Offset = "0x113E4C0")]
		private void <OnOperate>b__14_0()
		{
		}

		// Token: 0x04007915 RID: 30997
		[Token(Token = "0x4007915")]
		[FieldOffset(Offset = "0x18")]
		public UISprite RewardIcon;

		// Token: 0x04007916 RID: 30998
		[Token(Token = "0x4007916")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NecessaryActiveness;

		// Token: 0x04007917 RID: 30999
		[Token(Token = "0x4007917")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OperateButton;

		// Token: 0x04007918 RID: 31000
		[Token(Token = "0x4007918")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CanOpenEffect;

		// Token: 0x04007919 RID: 31001
		[Token(Token = "0x4007919")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OpenEffect;

		// Token: 0x0400791A RID: 31002
		[Token(Token = "0x400791A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ActivenessIcon;

		// Token: 0x0400791B RID: 31003
		[Token(Token = "0x400791B")]
		[FieldOffset(Offset = "0x48")]
		private UIModelActivity m_ModelActicity;

		// Token: 0x0400791C RID: 31004
		[Token(Token = "0x400791C")]
		[FieldOffset(Offset = "0x50")]
		private ActivenessReward m_Data;

		// Token: 0x0400791D RID: 31005
		[Token(Token = "0x400791D")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityActivenessRewardDescription.EOperateStatus m_OperateStatus;

		// Token: 0x0400791E RID: 31006
		[Token(Token = "0x400791E")]
		[FieldOffset(Offset = "0x60")]
		private string m_RewardDesc;

		// Token: 0x020013DB RID: 5083
		[Token(Token = "0x20013DB")]
		private enum EOperateStatus
		{
			// Token: 0x04007920 RID: 31008
			[Token(Token = "0x4007920")]
			None,
			// Token: 0x04007921 RID: 31009
			[Token(Token = "0x4007921")]
			UnFinished,
			// Token: 0x04007922 RID: 31010
			[Token(Token = "0x4007922")]
			CanReceive,
			// Token: 0x04007923 RID: 31011
			[Token(Token = "0x4007923")]
			Received
		}
	}
}
