using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001855 RID: 6229
	[Token(Token = "0x2001855")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3D7C", Offset = "0x10F3D7C")]
	internal class UIGroupMemberInfoController : UIBaseController
	{
		// Token: 0x06007A78 RID: 31352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A78")]
		[Address(RVA = "0x16A1ECC", Offset = "0x16A1ECC", VA = "0x7BBBEA1ECC")]
		public GroupMemberInfo GetMemberInfo()
		{
			return null;
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x00021B88 File Offset: 0x0001FD88
		[Token(Token = "0x6007A79")]
		[Address(RVA = "0x16A1ED4", Offset = "0x16A1ED4", VA = "0x7BBBEA1ED4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7A")]
		[Address(RVA = "0x16A1F24", Offset = "0x16A1F24", VA = "0x7BBBEA1F24", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7B")]
		[Address(RVA = "0x16A219C", Offset = "0x16A219C", VA = "0x7BBBEA219C")]
		private void Update()
		{
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7C")]
		[Address(RVA = "0x16A2650", Offset = "0x16A2650", VA = "0x7BBBEA2650", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7D")]
		[Address(RVA = "0x16A271C", Offset = "0x16A271C", VA = "0x7BBBEA271C")]
		public void SetUIData(GroupMemberInfo memInfo, bool leader, int idx = 0)
		{
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7E")]
		[Address(RVA = "0x16A2D78", Offset = "0x16A2D78", VA = "0x7BBBEA2D78")]
		public void SetRelationshipState()
		{
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A7F")]
		[Address(RVA = "0x16A2CEC", Offset = "0x16A2CEC", VA = "0x7BBBEA2CEC")]
		public void SetReadyState(bool ready, bool leader)
		{
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A80")]
		[Address(RVA = "0x16A30A8", Offset = "0x16A30A8", VA = "0x7BBBEA30A8")]
		public void SetFriendState(bool friend, [Optional] UIGroupMemberInfoController.InviteClickCallBack cb)
		{
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A81")]
		[Address(RVA = "0x16A31D0", Offset = "0x16A31D0", VA = "0x7BBBEA31D0")]
		public void OnInviteBtnClick()
		{
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A82")]
		[Address(RVA = "0x16A3694", Offset = "0x16A3694", VA = "0x7BBBEA3694")]
		public void EnableInivte(bool v)
		{
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A83")]
		[Address(RVA = "0x16A3708", Offset = "0x16A3708", VA = "0x7BBBEA3708")]
		public void ShowFriendIcon(bool v)
		{
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		[Token(Token = "0x6007A84")]
		[Address(RVA = "0x16A3764", Offset = "0x16A3764", VA = "0x7BBBEA3764")]
		private Color32 GetReadySpriteColor(bool isReady, bool leader = false)
		{
			return default(Color32);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		[Token(Token = "0x6007A85")]
		[Address(RVA = "0x16A37CC", Offset = "0x16A37CC", VA = "0x7BBBEA37CC")]
		private Color32 GetReadyTextColor(bool isReady, bool leader = false)
		{
			return default(Color32);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A86")]
		[Address(RVA = "0x16A3820", Offset = "0x16A3820", VA = "0x7BBBEA3820")]
		private void OnGroupChangeNtf(params object[] data)
		{
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A87")]
		[Address(RVA = "0x16A3918", Offset = "0x16A3918", VA = "0x7BBBEA3918")]
		public void UpdateFadePin()
		{
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A88")]
		[Address(RVA = "0x16A3A5C", Offset = "0x16A3A5C", VA = "0x7BBBEA3A5C")]
		private void OnClickAvatar()
		{
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A89")]
		[Address(RVA = "0x16A3EDC", Offset = "0x16A3EDC", VA = "0x7BBBEA3EDC")]
		public UIGroupMemberInfoController()
		{
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		[Token(Token = "0x6007A8A")]
		[Address(RVA = "0x16A3EF0", Offset = "0x16A3EF0", VA = "0x7BBBEA3EF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142404", Offset = "0x1142404")]
		private bool <OnClickAvatar>b__26_0(ClanMember temp)
		{
			return default(bool);
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A8B")]
		[Address(RVA = "0x16A3F54", Offset = "0x16A3F54", VA = "0x7BBBEA3F54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142414", Offset = "0x1142414")]
		private void <OnClickAvatar>b__26_1()
		{
		}

		// Token: 0x04008F31 RID: 36657
		[Token(Token = "0x4008F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int MemberIndex;

		// Token: 0x04008F32 RID: 36658
		[Token(Token = "0x4008F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GroupMemberInfo m_MemInfo;

		// Token: 0x04008F33 RID: 36659
		[Token(Token = "0x4008F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIGroupMemberInfoView m_View;

		// Token: 0x04008F34 RID: 36660
		[Token(Token = "0x4008F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIBriefProfileInfoController m_CallSign;

		// Token: 0x04008F35 RID: 36661
		[Token(Token = "0x4008F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_NextChangeIconTime;

		// Token: 0x04008F36 RID: 36662
		[Token(Token = "0x4008F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_ChangeIconInteval;

		// Token: 0x04008F37 RID: 36663
		[Token(Token = "0x4008F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_FadeIconTime;

		// Token: 0x04008F38 RID: 36664
		[Token(Token = "0x4008F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool m_CanFadePin;

		// Token: 0x04008F39 RID: 36665
		[Token(Token = "0x4008F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIGroupMemberInfoController.InviteClickCallBack m_CallBack;

		// Token: 0x02001856 RID: 6230
		// (Invoke) Token: 0x06007A8D RID: 31373
		[Token(Token = "0x2001856")]
		public delegate void InviteClickCallBack(int member_idx, ulong account_id);
	}
}
