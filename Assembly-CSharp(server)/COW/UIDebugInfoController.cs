using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001785 RID: 6021
	[Token(Token = "0x2001785")]
	internal class UIDebugInfoController : UISettingContentBase
	{
		// Token: 0x06007257 RID: 29271 RVA: 0x0001FD28 File Offset: 0x0001DF28
		[Token(Token = "0x6007257")]
		[Address(RVA = "0x1BBA884", Offset = "0x1BBA884", VA = "0x7BBC3BA884")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007258")]
		[Address(RVA = "0x1BBA8D4", Offset = "0x1BBA8D4", VA = "0x7BBC3BA8D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007259")]
		[Address(RVA = "0x1BBB0B0", Offset = "0x1BBB0B0", VA = "0x7BBC3BB0B0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725A")]
		[Address(RVA = "0x1BBB0B8", Offset = "0x1BBB0B8", VA = "0x7BBC3BB0B8")]
		private void OnDebugInfoClick()
		{
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725B")]
		[Address(RVA = "0x1BBB2A4", Offset = "0x1BBB2A4", VA = "0x7BBC3BB2A4")]
		private void OnTestChangeClothCheckBox()
		{
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725C")]
		[Address(RVA = "0x1BBB340", Offset = "0x1BBB340", VA = "0x7BBC3BB340")]
		private void OnTestAutoChangeClothCheckBox()
		{
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725D")]
		[Address(RVA = "0x1BBB3F0", Offset = "0x1BBB3F0", VA = "0x7BBC3BB3F0")]
		private void OnRemoteConsoleToggleChange()
		{
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725E")]
		[Address(RVA = "0x1BBB468", Offset = "0x1BBB468", VA = "0x7BBC3BB468")]
		private void OnRemoteConsoleBtnClick()
		{
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725F")]
		[Address(RVA = "0x1BBB6B8", Offset = "0x1BBB6B8", VA = "0x7BBC3BB6B8")]
		private void OnShowColliderClick()
		{
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007260")]
		[Address(RVA = "0x1BBB754", Offset = "0x1BBB754", VA = "0x7BBC3BB754")]
		private void OnShowTriggerClick()
		{
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007261")]
		[Address(RVA = "0x1BBB7F0", Offset = "0x1BBB7F0", VA = "0x7BBC3BB7F0")]
		private void OnRebuildClick()
		{
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x1BBB88C", Offset = "0x1BBB88C", VA = "0x7BBC3BB88C")]
		private void OnDestroyClick()
		{
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007263")]
		[Address(RVA = "0x1BBAE70", Offset = "0x1BBAE70", VA = "0x7BBC3BAE70")]
		private void InitLogLevels()
		{
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007264")]
		[Address(RVA = "0x1BBB9FC", Offset = "0x1BBB9FC", VA = "0x7BBC3BB9FC")]
		private void OnLogLevelChange()
		{
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x0001FD40 File Offset: 0x0001DF40
		[Token(Token = "0x6007265")]
		[Address(RVA = "0x1BBB928", Offset = "0x1BBB928", VA = "0x7BBC3BB928")]
		private LogType GetLogLevelInSetting()
		{
			return LogType.Error;
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x0001FD58 File Offset: 0x0001DF58
		[Token(Token = "0x6007266")]
		[Address(RVA = "0x1BBBB08", Offset = "0x1BBBB08", VA = "0x7BBC3BBB08")]
		private LogType GetLogLevelInToggles(LogType defaultVal)
		{
			return LogType.Error;
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007267")]
		[Address(RVA = "0x1BBBD48", Offset = "0x1BBBD48", VA = "0x7BBC3BBD48")]
		public UIDebugInfoController()
		{
		}

		// Token: 0x04008B66 RID: 35686
		[Token(Token = "0x4008B66")]
		[FieldOffset(Offset = "0x60")]
		private UIDebugSettingView m_View;
	}
}
