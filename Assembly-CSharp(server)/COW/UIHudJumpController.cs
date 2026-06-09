using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018FA RID: 6394
	[Token(Token = "0x20018FA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5574", Offset = "0x10F5574")]
	internal class UIHudJumpController : UIHudButtonBaseController
	{
		// Token: 0x06008055 RID: 32853 RVA: 0x00022FF8 File Offset: 0x000211F8
		[Token(Token = "0x6008055")]
		[Address(RVA = "0x1C4D524", Offset = "0x1C4D524", VA = "0x7BBC44D524")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008056")]
		[Address(RVA = "0x1C4D574", Offset = "0x1C4D574", VA = "0x7BBC44D574", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008057")]
		[Address(RVA = "0x1C4D890", Offset = "0x1C4D890", VA = "0x7BBC44D890", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008058")]
		[Address(RVA = "0x1C4DB00", Offset = "0x1C4DB00", VA = "0x7BBC44DB00")]
		private void OnReadyToClimb(params object[] data)
		{
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008059")]
		[Address(RVA = "0x1C4DE60", Offset = "0x1C4DE60", VA = "0x7BBC44DE60")]
		private void ResetIconPos()
		{
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805A")]
		[Address(RVA = "0x1C4DEE0", Offset = "0x1C4DEE0", VA = "0x7BBC44DEE0")]
		private void OnReadyToGlide(params object[] data)
		{
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805B")]
		[Address(RVA = "0x1C4E15C", Offset = "0x1C4E15C", VA = "0x7BBC44E15C")]
		private void OnEquipJumpShoes(params object[] data)
		{
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805C")]
		[Address(RVA = "0x1C4E1A0", Offset = "0x1C4E1A0", VA = "0x7BBC44E1A0")]
		private void OnUnEquipJumpShoes(params object[] data)
		{
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805D")]
		[Address(RVA = "0x1C4E1E4", Offset = "0x1C4E1E4", VA = "0x7BBC44E1E4")]
		private void OnEnergyChange(params object[] data)
		{
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600805E")]
		[Address(RVA = "0x1C4E3AC", Offset = "0x1C4E3AC", VA = "0x7BBC44E3AC")]
		private void OnHumanTireJumpStateChange(params object[] data)
		{
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600805F")]
		[Address(RVA = "0x1C4E504", Offset = "0x1C4E504", VA = "0x7BBC44E504", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008060")]
		[Address(RVA = "0x1C4E54C", Offset = "0x1C4E54C", VA = "0x7BBC44E54C")]
		private void Update()
		{
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008061")]
		[Address(RVA = "0x1C4E61C", Offset = "0x1C4E61C", VA = "0x7BBC44E61C")]
		private void SetHightlight(bool flag)
		{
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008062")]
		[Address(RVA = "0x1C4E760", Offset = "0x1C4E760", VA = "0x7BBC44E760")]
		public UIHudJumpController()
		{
		}

		// Token: 0x04009296 RID: 37526
		[Token(Token = "0x4009296")]
		[FieldOffset(Offset = "0x60")]
		private UIHudJumpView m_View;

		// Token: 0x04009297 RID: 37527
		[Token(Token = "0x4009297")]
		private const string m_JumpIcon = "UI_icon_jump";

		// Token: 0x04009298 RID: 37528
		[Token(Token = "0x4009298")]
		private const string m_HumanTireJumpIcon = "UI_icon_humantire";

		// Token: 0x04009299 RID: 37529
		[Token(Token = "0x4009299")]
		[FieldOffset(Offset = "0x68")]
		private bool m_Isfalling;

		// Token: 0x0400929A RID: 37530
		[Token(Token = "0x400929A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 defatultpos;

		// Token: 0x0400929B RID: 37531
		[Token(Token = "0x400929B")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 climbpos;
	}
}
