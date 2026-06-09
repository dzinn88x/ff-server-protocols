using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200195C RID: 6492
	[Token(Token = "0x200195C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F61F4", Offset = "0x10F61F4")]
	public class UIHudSkillTemplateController : UIBaseController
	{
		// Token: 0x060083D2 RID: 33746 RVA: 0x00023CE8 File Offset: 0x00021EE8
		[Token(Token = "0x60083D2")]
		[Address(RVA = "0x1669A1C", Offset = "0x1669A1C", VA = "0x7BBBE69A1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D3")]
		[Address(RVA = "0x1669A6C", Offset = "0x1669A6C", VA = "0x7BBBE69A6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D4")]
		[Address(RVA = "0x1669CF0", Offset = "0x1669CF0", VA = "0x7BBBE69CF0")]
		public void RefreshSkillData(AvatarSkillData data)
		{
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D5")]
		[Address(RVA = "0x1669F94", Offset = "0x1669F94", VA = "0x7BBBE69F94")]
		public void SetActiveSkillIcon()
		{
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D6")]
		[Address(RVA = "0x166A30C", Offset = "0x166A30C", VA = "0x7BBBE6A30C")]
		public void CheckSkillNeedShowCDAnim()
		{
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D7")]
		[Address(RVA = "0x166A59C", Offset = "0x166A59C", VA = "0x7BBBE6A59C")]
		private void OnBtnClick()
		{
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D8")]
		[Address(RVA = "0x166A5A0", Offset = "0x166A5A0", VA = "0x7BBBE6A5A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D9")]
		[Address(RVA = "0x166A5A8", Offset = "0x166A5A8", VA = "0x7BBBE6A5A8")]
		private void TryGetCameraComponent()
		{
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x00023D00 File Offset: 0x00021F00
		[Token(Token = "0x60083DA")]
		[Address(RVA = "0x166A68C", Offset = "0x166A68C", VA = "0x7BBBE6A68C")]
		private bool CheckPos(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x00023D18 File Offset: 0x00021F18
		[Token(Token = "0x60083DB")]
		[Address(RVA = "0x166A944", Offset = "0x166A944", VA = "0x7BBBE6A944")]
		private bool CheckMobileTouch()
		{
			return default(bool);
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x00023D30 File Offset: 0x00021F30
		[Token(Token = "0x60083DC")]
		[Address(RVA = "0x166A9E8", Offset = "0x166A9E8", VA = "0x7BBBE6A9E8")]
		private bool CheckPcTouch(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083DD")]
		[Address(RVA = "0x166AA7C", Offset = "0x166AA7C", VA = "0x7BBBE6AA7C")]
		public void OnPlayBrightAnim(string skillAnimType, bool animValue)
		{
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083DE")]
		[Address(RVA = "0x166AEA0", Offset = "0x166AEA0", VA = "0x7BBBE6AEA0")]
		public void OnPlayFlashAnim(string skillAnimType)
		{
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083DF")]
		[Address(RVA = "0x166A49C", Offset = "0x166A49C", VA = "0x7BBBE6A49C")]
		public void OnPlayCoolDownAnim(float cdTime, int cdEndTime)
		{
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E0")]
		[Address(RVA = "0x166B058", Offset = "0x166B058", VA = "0x7BBBE6B058")]
		private void InitFlashAnimState()
		{
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E1")]
		[Address(RVA = "0x166B0A4", Offset = "0x166B0A4", VA = "0x7BBBE6B0A4")]
		private void UpdateFlashAnimState()
		{
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E2")]
		[Address(RVA = "0x166AD5C", Offset = "0x166AD5C", VA = "0x7BBBE6AD5C")]
		public void PlayBrightAnim(bool isFlash = false)
		{
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E3")]
		[Address(RVA = "0x166AE14", Offset = "0x166AE14", VA = "0x7BBBE6AE14")]
		public void ResetBrightAnim()
		{
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E4")]
		[Address(RVA = "0x166B168", Offset = "0x166B168", VA = "0x7BBBE6B168")]
		private void Update()
		{
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083E5")]
		[Address(RVA = "0x166B450", Offset = "0x166B450", VA = "0x7BBBE6B450")]
		public UIHudSkillTemplateController()
		{
		}

		// Token: 0x04009472 RID: 38002
		[Token(Token = "0x4009472")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSkillTemplateView m_View;

		// Token: 0x04009473 RID: 38003
		[Token(Token = "0x4009473")]
		[FieldOffset(Offset = "0x60")]
		private UICamera m_UICamera;

		// Token: 0x04009474 RID: 38004
		[Token(Token = "0x4009474")]
		[FieldOffset(Offset = "0x68")]
		private Camera m_Camera;

		// Token: 0x04009475 RID: 38005
		[Token(Token = "0x4009475")]
		[FieldOffset(Offset = "0x70")]
		private float dist;

		// Token: 0x04009476 RID: 38006
		[Token(Token = "0x4009476")]
		[FieldOffset(Offset = "0x78")]
		public string m_SkillType;

		// Token: 0x04009477 RID: 38007
		[Token(Token = "0x4009477")]
		[FieldOffset(Offset = "0x80")]
		private float m_NextLoopAnimTime;

		// Token: 0x04009478 RID: 38008
		[Token(Token = "0x4009478")]
		[FieldOffset(Offset = "0x84")]
		private bool m_IsLoopAnim;

		// Token: 0x04009479 RID: 38009
		[Token(Token = "0x4009479")]
		[FieldOffset(Offset = "0x88")]
		private float m_SkillCoolingTime;

		// Token: 0x0400947A RID: 38010
		[Token(Token = "0x400947A")]
		[FieldOffset(Offset = "0x8C")]
		private float m_SkillCDTime;

		// Token: 0x0400947B RID: 38011
		[Token(Token = "0x400947B")]
		[FieldOffset(Offset = "0x90")]
		private int m_SkillCDEndTime;

		// Token: 0x0400947C RID: 38012
		[Token(Token = "0x400947C")]
		[FieldOffset(Offset = "0x94")]
		private bool m_ShowCDAnim;

		// Token: 0x0400947D RID: 38013
		[Token(Token = "0x400947D")]
		private const string ActiveSkillBg = "icon_ingame_KillFeast_BG";

		// Token: 0x0400947E RID: 38014
		[Token(Token = "0x400947E")]
		[FieldOffset(Offset = "0x95")]
		private bool m_HasInitActiveSkill;

		// Token: 0x0400947F RID: 38015
		[Token(Token = "0x400947F")]
		[FieldOffset(Offset = "0x96")]
		private bool m_IsActiveSkill;

		// Token: 0x04009480 RID: 38016
		[Token(Token = "0x4009480")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 m_ActiveSkillDescOffset;
	}
}
