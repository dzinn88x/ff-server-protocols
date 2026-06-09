using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200136B RID: 4971
	[Token(Token = "0x200136B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB470", Offset = "0x10EB470")]
	public class UIFFWSTaskController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06004F89 RID: 20361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F89")]
		[Address(RVA = "0x2289438", Offset = "0x2289438", VA = "0x7BBCA89438", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0x2289FE4", Offset = "0x2289FE4", VA = "0x7BBCA89FE4", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8B")]
		[Address(RVA = "0x228A198", Offset = "0x228A198", VA = "0x7BBCA8A198", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8C")]
		[Address(RVA = "0x228A3CC", Offset = "0x228A3CC", VA = "0x7BBCA8A3CC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00018348 File Offset: 0x00016548
		[Token(Token = "0x6004F8D")]
		[Address(RVA = "0x228A51C", Offset = "0x228A51C", VA = "0x7BBCA8A51C", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x00018360 File Offset: 0x00016560
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x228A524", Offset = "0x228A524", VA = "0x7BBCA8A524")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x228A574", Offset = "0x228A574", VA = "0x7BBCA8A574", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00018378 File Offset: 0x00016578
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x228AAA4", Offset = "0x228AAA4", VA = "0x7BBCA8AAA4", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x2289BF0", Offset = "0x2289BF0", VA = "0x7BBCA89BF0")]
		private void CreateTaskItems()
		{
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x2289D94", Offset = "0x2289D94", VA = "0x7BBCA89D94")]
		private void RefreshNetworkBg()
		{
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x2289E94", Offset = "0x2289E94", VA = "0x7BBCA89E94")]
		private void InitView()
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x228A0A0", Offset = "0x228A0A0", VA = "0x7BBCA8A0A0")]
		private void RefreshView()
		{
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x228A948", Offset = "0x228A948", VA = "0x7BBCA8A948")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x228AB28", Offset = "0x228AB28", VA = "0x7BBCA8AB28")]
		private void RefreshTasks()
		{
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x228ACD4", Offset = "0x228ACD4", VA = "0x7BBCA8ACD4")]
		private void RefreshSpTask()
		{
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x228A6FC", Offset = "0x228A6FC", VA = "0x7BBCA8A6FC")]
		private void RefreshStoryDialogue()
		{
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x228A0CC", Offset = "0x228A0CC", VA = "0x7BBCA8A0CC")]
		private void RefreshAvatarStatus()
		{
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x228B9E4", Offset = "0x228B9E4", VA = "0x7BBCA8B9E4")]
		public void ShowFirstDialogue()
		{
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x228B8A4", Offset = "0x228B8A4", VA = "0x7BBCA8B8A4")]
		public void SetDialogueData([Optional] FFWSSpecialTaskTextDesc desc)
		{
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x22898EC", Offset = "0x22898EC", VA = "0x7BBCA898EC")]
		private void RefreshProgress()
		{
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x228BDF8", Offset = "0x228BDF8", VA = "0x7BBCA8BDF8")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x228BFB4", Offset = "0x228BFB4", VA = "0x7BBCA8BFB4")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x228C050", Offset = "0x228C050", VA = "0x7BBCA8C050")]
		private void OnContinueClick()
		{
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA0")]
		[Address(RVA = "0x228C2BC", Offset = "0x228C2BC", VA = "0x7BBCA8C2BC")]
		private void OnAcceptClick()
		{
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0x228C478", Offset = "0x228C478", VA = "0x7BBCA8C478")]
		private void OnTokenClick()
		{
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0x228C6B8", Offset = "0x228C6B8", VA = "0x7BBCA8C6B8")]
		private void OnShopEntranceClick()
		{
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x228C81C", Offset = "0x228C81C", VA = "0x7BBCA8C81C")]
		private void OnProcessingEffectShow(object[] data)
		{
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x228C9B4", Offset = "0x228C9B4", VA = "0x7BBCA8C9B4")]
		private void OnProcessingEffectFromPosChanged(object[] data)
		{
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x228CA44", Offset = "0x228CA44", VA = "0x7BBCA8CA44")]
		private void OnProgressVFXPlayed()
		{
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0x228CABC", Offset = "0x228CABC", VA = "0x7BBCA8CABC")]
		public UIFFWSTaskController()
		{
		}

		// Token: 0x04007642 RID: 30274
		[Token(Token = "0x4007642")]
		private const string SPTASK_READ = "OB27_FFWS_SpTask";

		// Token: 0x04007643 RID: 30275
		[Token(Token = "0x4007643")]
		private const float FLYINGPARTICLESPEED = 2f;

		// Token: 0x04007644 RID: 30276
		[Token(Token = "0x4007644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int m_DialogueTextIndex;

		// Token: 0x04007645 RID: 30277
		[Token(Token = "0x4007645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<string> m_DialogueTextList;

		// Token: 0x04007646 RID: 30278
		[Token(Token = "0x4007646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIFFWSTaskView m_View;

		// Token: 0x04007647 RID: 30279
		[Token(Token = "0x4007647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x04007648 RID: 30280
		[Token(Token = "0x4007648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007649 RID: 30281
		[Token(Token = "0x4007649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<UIFFWSTaskItemController> m_TaskUIList;

		// Token: 0x0400764A RID: 30282
		[Token(Token = "0x400764A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIFFWSTaskItemController m_SpTaskUI;

		// Token: 0x0400764B RID: 30283
		[Token(Token = "0x400764B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<ClientActivityDesc> m_ActivityDescList;

		// Token: 0x0400764C RID: 30284
		[Token(Token = "0x400764C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ClientActivityDesc m_SpActivityDesc;

		// Token: 0x0400764D RID: 30285
		[Token(Token = "0x400764D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private uint m_ProgressDelayCallID;

		// Token: 0x0400764E RID: 30286
		[Token(Token = "0x400764E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 mFrom;

		// Token: 0x0400764F RID: 30287
		[Token(Token = "0x400764F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 mTo;
	}
}
