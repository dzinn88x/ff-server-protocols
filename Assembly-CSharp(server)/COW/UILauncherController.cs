using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025EB RID: 9707
	[Token(Token = "0x20025EB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDED4", Offset = "0x10FDED4")]
	internal class UILauncherController : UIBaseController
	{
		// Token: 0x0600C860 RID: 51296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C860")]
		[Address(RVA = "0x1E9C5DC", Offset = "0x1E9C5DC", VA = "0x7BBC69C5DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C861")]
		[Address(RVA = "0x1E9C6D4", Offset = "0x1E9C6D4", VA = "0x7BBC69C6D4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600C862 RID: 51298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C862")]
		[Address(RVA = "0x1E9CCC8", Offset = "0x1E9CCC8", VA = "0x7BBC69CCC8")]
		private void AppFlyerTrackStart()
		{
		}

		// Token: 0x0600C863 RID: 51299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C863")]
		[Address(RVA = "0x1E9CDE4", Offset = "0x1E9CDE4", VA = "0x7BBC69CDE4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600C864 RID: 51300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C864")]
		[Address(RVA = "0x1E9CFCC", Offset = "0x1E9CFCC", VA = "0x7BBC69CFCC")]
		private void Update()
		{
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C865")]
		[Address(RVA = "0x1E9DC98", Offset = "0x1E9DC98", VA = "0x7BBC69DC98")]
		private void RetrieveVerInfo()
		{
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C866")]
		[Address(RVA = "0x1E9E3D4", Offset = "0x1E9E3D4", VA = "0x7BBC69E3D4")]
		private void OpenFFMaxIntro()
		{
		}

		// Token: 0x0600C867 RID: 51303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C867")]
		[Address(RVA = "0x1E9C95C", Offset = "0x1E9C95C", VA = "0x7BBC69C95C")]
		private void CheckVersion()
		{
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C868")]
		[Address(RVA = "0x1E9E634", Offset = "0x1E9E634", VA = "0x7BBC69E634")]
		private void OnColdUpdate()
		{
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C869")]
		[Address(RVA = "0x1E9E960", Offset = "0x1E9E960", VA = "0x7BBC69E960")]
		private void OnHotUpdateError()
		{
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C86A")]
		[Address(RVA = "0x1E9EBCC", Offset = "0x1E9EBCC", VA = "0x7BBC69EBCC")]
		private void OnLocUpdateError(ResErrorCode last_err)
		{
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C86B")]
		[Address(RVA = "0x1E9EF20", Offset = "0x1E9EF20", VA = "0x7BBC69EF20")]
		private void OnHotUpdateFinished(ResErrorCode result)
		{
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C86C")]
		[Address(RVA = "0x1E9EF28", Offset = "0x1E9EF28", VA = "0x7BBC69EF28")]
		private void OnHotUpdateFinished(ResErrorCode result, bool is_from_pass)
		{
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C86D")]
		[Address(RVA = "0x1E9F1A0", Offset = "0x1E9F1A0", VA = "0x7BBC69F1A0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1148104", Offset = "0x1148104")]
		private IEnumerator StartLaunchGame()
		{
			return null;
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C86E")]
		[Address(RVA = "0x1E9F214", Offset = "0x1E9F214", VA = "0x7BBC69F214")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1148168", Offset = "0x1148168")]
		private IEnumerator StartHotUpdating()
		{
			return null;
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C86F")]
		[Address(RVA = "0x1E9F288", Offset = "0x1E9F288", VA = "0x7BBC69F288")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11481CC", Offset = "0x11481CC")]
		private IEnumerator StartCheckVersion()
		{
			return null;
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C870")]
		[Address(RVA = "0x1E9F328", Offset = "0x1E9F328", VA = "0x7BBC69F328")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1148230", Offset = "0x1148230")]
		private IEnumerator StartLocDownload()
		{
			return null;
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C871")]
		[Address(RVA = "0x1E9E610", Offset = "0x1E9E610", VA = "0x7BBC69E610")]
		private void OnStartUpdating()
		{
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C872")]
		[Address(RVA = "0x1E9E930", Offset = "0x1E9E930", VA = "0x7BBC69E930")]
		private void OnFinishUpdating()
		{
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C873")]
		[Address(RVA = "0x1E9C84C", Offset = "0x1E9C84C", VA = "0x7BBC69C84C")]
		private void SetActiveGroup(uint activeGroup)
		{
		}

		// Token: 0x0600C874 RID: 51316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C874")]
		[Address(RVA = "0x1E9F39C", Offset = "0x1E9F39C", VA = "0x7BBC69F39C")]
		private void SetPreviousActiveGroup()
		{
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C875")]
		[Address(RVA = "0x1E9F3A4", Offset = "0x1E9F3A4", VA = "0x7BBC69F3A4")]
		private void OnLocDownloaded(ResErrorCode err_code, ResDownloadType type)
		{
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C876")]
		[Address(RVA = "0x1E9F3F0", Offset = "0x1E9F3F0", VA = "0x7BBC69F3F0")]
		public UILauncherController()
		{
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C877")]
		[Address(RVA = "0x1E9F408", Offset = "0x1E9F408", VA = "0x7BBC69F408")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148294", Offset = "0x1148294")]
		private void <Update>b__30_0()
		{
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C878")]
		[Address(RVA = "0x1E9F414", Offset = "0x1E9F414", VA = "0x7BBC69F414")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482A4", Offset = "0x11482A4")]
		private void <Update>b__30_1()
		{
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C879")]
		[Address(RVA = "0x1E9F420", Offset = "0x1E9F420", VA = "0x7BBC69F420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482B4", Offset = "0x11482B4")]
		private void <RetrieveVerInfo>b__34_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600C87A RID: 51322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87A")]
		[Address(RVA = "0x1EA0288", Offset = "0x1EA0288", VA = "0x7BBC6A0288")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482C4", Offset = "0x11482C4")]
		private void <RetrieveVerInfo>b__34_1()
		{
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87B")]
		[Address(RVA = "0x1EA03C4", Offset = "0x1EA03C4", VA = "0x7BBC6A03C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482D4", Offset = "0x11482D4")]
		private void <OpenFFMaxIntro>b__35_0()
		{
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87C")]
		[Address(RVA = "0x1EA03CC", Offset = "0x1EA03CC", VA = "0x7BBC6A03CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482E4", Offset = "0x11482E4")]
		private void <CheckVersion>b__36_0(ResHotUpdateResult result)
		{
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87D")]
		[Address(RVA = "0x1EA0718", Offset = "0x1EA0718", VA = "0x7BBC6A0718")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11482F4", Offset = "0x11482F4")]
		private void <CheckVersion>b__36_1(ResHotUpdateResult result)
		{
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87E")]
		[Address(RVA = "0x1EA080C", Offset = "0x1EA080C", VA = "0x7BBC6A080C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148304", Offset = "0x1148304")]
		private void <CheckVersion>b__36_2(ResHotUpdateResult result)
		{
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C87F")]
		[Address(RVA = "0x1EA0D50", Offset = "0x1EA0D50", VA = "0x7BBC6A0D50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148314", Offset = "0x1148314")]
		private void <OnColdUpdate>b__37_0()
		{
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C880")]
		[Address(RVA = "0x1EA0E8C", Offset = "0x1EA0E8C", VA = "0x7BBC6A0E8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148324", Offset = "0x1148324")]
		private void <OnHotUpdateError>b__38_0()
		{
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C881")]
		[Address(RVA = "0x1EA1100", Offset = "0x1EA1100", VA = "0x7BBC6A1100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148334", Offset = "0x1148334")]
		private void <OnLocUpdateError>b__39_0()
		{
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C882")]
		[Address(RVA = "0x1EA11AC", Offset = "0x1EA11AC", VA = "0x7BBC6A11AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148344", Offset = "0x1148344")]
		private void <OnLocUpdateError>b__39_1()
		{
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C883")]
		[Address(RVA = "0x1EA126C", Offset = "0x1EA126C", VA = "0x7BBC6A126C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148354", Offset = "0x1148354")]
		private void <OnLocUpdateError>b__39_2()
		{
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C884")]
		[Address(RVA = "0x1EA1324", Offset = "0x1EA1324", VA = "0x7BBC6A1324")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148364", Offset = "0x1148364")]
		private void <OnHotUpdateFinished>b__41_0(ResErrorCode ret, ResDownloadType type)
		{
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C885")]
		[Address(RVA = "0x1EA152C", Offset = "0x1EA152C", VA = "0x7BBC6A152C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148374", Offset = "0x1148374")]
		private void <OnHotUpdateFinished>b__41_1()
		{
		}

		// Token: 0x0400FABC RID: 64188
		[Token(Token = "0x400FABC")]
		[FieldOffset(Offset = "0x58")]
		public Action OnLaunchGame;

		// Token: 0x0400FABD RID: 64189
		[Token(Token = "0x400FABD")]
		[FieldOffset(Offset = "0x60")]
		public UILauncherController.CreateMessageBox OnCreateMessageBox;

		// Token: 0x0400FABE RID: 64190
		[Token(Token = "0x400FABE")]
		[FieldOffset(Offset = "0x68")]
		public bool IsRestart;

		// Token: 0x0400FABF RID: 64191
		[Token(Token = "0x400FABF")]
		private const uint UI_GROUP_HOTUPDATE = 2U;

		// Token: 0x0400FAC0 RID: 64192
		[Token(Token = "0x400FAC0")]
		private const uint UI_GROUP_MAX = 4U;

		// Token: 0x0400FAC1 RID: 64193
		[Token(Token = "0x400FAC1")]
		private const uint UI_GROUP_QUIT = 8U;

		// Token: 0x0400FAC2 RID: 64194
		[Token(Token = "0x400FAC2")]
		[FieldOffset(Offset = "0x70")]
		private UILauncherPopupMessageController m_MessageBox;

		// Token: 0x0400FAC3 RID: 64195
		[Token(Token = "0x400FAC3")]
		[FieldOffset(Offset = "0x78")]
		private UILauncherMaxController m_FFMaxMessageBox;

		// Token: 0x0400FAC4 RID: 64196
		[Token(Token = "0x400FAC4")]
		[FieldOffset(Offset = "0x80")]
		private UIPopupMessageBoxController m_QuitMessageBox;

		// Token: 0x0400FAC5 RID: 64197
		[Token(Token = "0x400FAC5")]
		[FieldOffset(Offset = "0x88")]
		private UILauncherView m_View;

		// Token: 0x0400FAC6 RID: 64198
		[Token(Token = "0x400FAC6")]
		[FieldOffset(Offset = "0x90")]
		private float m_Progress;

		// Token: 0x0400FAC7 RID: 64199
		[Token(Token = "0x400FAC7")]
		[FieldOffset(Offset = "0x94")]
		private float m_TotalHotUpdatingMBytes;

		// Token: 0x0400FAC8 RID: 64200
		[Token(Token = "0x400FAC8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_IsHotUpdating;

		// Token: 0x0400FAC9 RID: 64201
		[Token(Token = "0x400FAC9")]
		[FieldOffset(Offset = "0x99")]
		private bool m_IsUnzipping;

		// Token: 0x0400FACA RID: 64202
		[Token(Token = "0x400FACA")]
		[FieldOffset(Offset = "0x9C")]
		private int m_LastSleepTimeout;

		// Token: 0x0400FACB RID: 64203
		[Token(Token = "0x400FACB")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_LastRunInBackground;

		// Token: 0x0400FACC RID: 64204
		[Token(Token = "0x400FACC")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_Cleanup;

		// Token: 0x0400FACD RID: 64205
		[Token(Token = "0x400FACD")]
		[FieldOffset(Offset = "0xA8")]
		private UILauncherController.HttpVerInfo remoteVerInfo;

		// Token: 0x0400FACE RID: 64206
		[Token(Token = "0x400FACE")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_NeedTrackHotUpdate;

		// Token: 0x0400FACF RID: 64207
		[Token(Token = "0x400FACF")]
		[FieldOffset(Offset = "0xB4")]
		private float m_ShowMessageSize;

		// Token: 0x0400FAD0 RID: 64208
		[Token(Token = "0x400FAD0")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_IsDownloadingLoc;

		// Token: 0x0400FAD1 RID: 64209
		[Token(Token = "0x400FAD1")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_IsLoadingGame;

		// Token: 0x0400FAD2 RID: 64210
		[Token(Token = "0x400FAD2")]
		[FieldOffset(Offset = "0xBC")]
		private int m_LocErrorCount;

		// Token: 0x0400FAD3 RID: 64211
		[Token(Token = "0x400FAD3")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_NeedUseBackUpCDN;

		// Token: 0x0400FAD4 RID: 64212
		[Token(Token = "0x400FAD4")]
		[FieldOffset(Offset = "0xC4")]
		private int m_RemoteFileInfoErrCount;

		// Token: 0x0400FAD5 RID: 64213
		[Token(Token = "0x400FAD5")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_CanInGameHotupdate;

		// Token: 0x0400FAD6 RID: 64214
		[Token(Token = "0x400FAD6")]
		[FieldOffset(Offset = "0xCC")]
		private uint m_PrevActiveGroup;

		// Token: 0x0400FAD7 RID: 64215
		[Token(Token = "0x400FAD7")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_LastActiveGroup;

		// Token: 0x020025EC RID: 9708
		// (Invoke) Token: 0x0600C887 RID: 51335
		[Token(Token = "0x20025EC")]
		public delegate UIBaseController CreateMessageBox(string path, Type classType);

		// Token: 0x020025ED RID: 9709
		[Token(Token = "0x20025ED")]
		private enum EHttpVerInfoErrorCode
		{
			// Token: 0x0400FAD9 RID: 64217
			[Token(Token = "0x400FAD9")]
			OK,
			// Token: 0x0400FADA RID: 64218
			[Token(Token = "0x400FADA")]
			ERROR,
			// Token: 0x0400FADB RID: 64219
			[Token(Token = "0x400FADB")]
			NOVERSIONFOUND
		}

		// Token: 0x020025EE RID: 9710
		[Token(Token = "0x20025EE")]
		private class HttpVerInfo
		{
			// Token: 0x0600C88A RID: 51338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C88A")]
			[Address(RVA = "0x1E26200", Offset = "0x1E26200", VA = "0x7BBC626200")]
			public HttpVerInfo()
			{
			}

			// Token: 0x0400FADC RID: 64220
			[Token(Token = "0x400FADC")]
			[FieldOffset(Offset = "0x10")]
			public uint code;

			// Token: 0x0400FADD RID: 64221
			[Token(Token = "0x400FADD")]
			[FieldOffset(Offset = "0x14")]
			public bool is_server_open;

			// Token: 0x0400FADE RID: 64222
			[Token(Token = "0x400FADE")]
			[FieldOffset(Offset = "0x15")]
			public bool is_firewall_open;

			// Token: 0x0400FADF RID: 64223
			[Token(Token = "0x400FADF")]
			[FieldOffset(Offset = "0x16")]
			public bool need_track_hotupdate;

			// Token: 0x0400FAE0 RID: 64224
			[Token(Token = "0x400FAE0")]
			[FieldOffset(Offset = "0x18")]
			public double min_hint_size;

			// Token: 0x0400FAE1 RID: 64225
			[Token(Token = "0x400FAE1")]
			[FieldOffset(Offset = "0x20")]
			public string billboard_cdn_url;

			// Token: 0x0400FAE2 RID: 64226
			[Token(Token = "0x400FAE2")]
			[FieldOffset(Offset = "0x28")]
			public string billboard_msg;

			// Token: 0x0400FAE3 RID: 64227
			[Token(Token = "0x400FAE3")]
			[FieldOffset(Offset = "0x30")]
			public string patchnote_url;

			// Token: 0x0400FAE4 RID: 64228
			[Token(Token = "0x400FAE4")]
			[FieldOffset(Offset = "0x38")]
			public string web_url;

			// Token: 0x0400FAE5 RID: 64229
			[Token(Token = "0x400FAE5")]
			[FieldOffset(Offset = "0x40")]
			public string billboard_bg_url;

			// Token: 0x0400FAE6 RID: 64230
			[Token(Token = "0x400FAE6")]
			[FieldOffset(Offset = "0x48")]
			public string max_store;

			// Token: 0x0400FAE7 RID: 64231
			[Token(Token = "0x400FAE7")]
			[FieldOffset(Offset = "0x50")]
			public string max_web;

			// Token: 0x0400FAE8 RID: 64232
			[Token(Token = "0x400FAE8")]
			[FieldOffset(Offset = "0x58")]
			public string max_video;

			// Token: 0x0400FAE9 RID: 64233
			[Token(Token = "0x400FAE9")]
			[FieldOffset(Offset = "0x60")]
			public string remote_version;

			// Token: 0x0400FAEA RID: 64234
			[Token(Token = "0x400FAEA")]
			[FieldOffset(Offset = "0x68")]
			public string remote_option_version;

			// Token: 0x0400FAEB RID: 64235
			[Token(Token = "0x400FAEB")]
			[FieldOffset(Offset = "0x70")]
			public string cdn_url;

			// Token: 0x0400FAEC RID: 64236
			[Token(Token = "0x400FAEC")]
			[FieldOffset(Offset = "0x78")]
			public string backup_cdn_url;

			// Token: 0x0400FAED RID: 64237
			[Token(Token = "0x400FAED")]
			[FieldOffset(Offset = "0x80")]
			public string server_url;

			// Token: 0x0400FAEE RID: 64238
			[Token(Token = "0x400FAEE")]
			[FieldOffset(Offset = "0x88")]
			public bool is_review_server;

			// Token: 0x0400FAEF RID: 64239
			[Token(Token = "0x400FAEF")]
			[FieldOffset(Offset = "0x90")]
			public string appstore_url;

			// Token: 0x0400FAF0 RID: 64240
			[Token(Token = "0x400FAF0")]
			[FieldOffset(Offset = "0x98")]
			public bool force_to_restart_app;

			// Token: 0x0400FAF1 RID: 64241
			[Token(Token = "0x400FAF1")]
			[FieldOffset(Offset = "0xA0")]
			public string country_code;

			// Token: 0x0400FAF2 RID: 64242
			[Token(Token = "0x400FAF2")]
			[FieldOffset(Offset = "0xA8")]
			public int gdpr_version;

			// Token: 0x0400FAF3 RID: 64243
			[Token(Token = "0x400FAF3")]
			[FieldOffset(Offset = "0xB0")]
			public string client_ip;

			// Token: 0x0400FAF4 RID: 64244
			[Token(Token = "0x400FAF4")]
			[FieldOffset(Offset = "0xB8")]
			public string maintenance_announcement;

			// Token: 0x0400FAF5 RID: 64245
			[Token(Token = "0x400FAF5")]
			[FieldOffset(Offset = "0xC0")]
			public string maintenance_region;

			// Token: 0x0400FAF6 RID: 64246
			[Token(Token = "0x400FAF6")]
			[FieldOffset(Offset = "0xC8")]
			public string[] need_check_ip_list;

			// Token: 0x0400FAF7 RID: 64247
			[Token(Token = "0x400FAF7")]
			[FieldOffset(Offset = "0xD0")]
			public string network_log_server;

			// Token: 0x0400FAF8 RID: 64248
			[Token(Token = "0x400FAF8")]
			[FieldOffset(Offset = "0xD8")]
			public int login_failed_count;

			// Token: 0x0400FAF9 RID: 64249
			[Token(Token = "0x400FAF9")]
			[FieldOffset(Offset = "0xE0")]
			public string test_url;

			// Token: 0x0400FAFA RID: 64250
			[Token(Token = "0x400FAFA")]
			[FieldOffset(Offset = "0xE8")]
			public string img_cdn_url;

			// Token: 0x0400FAFB RID: 64251
			[Token(Token = "0x400FAFB")]
			[FieldOffset(Offset = "0xF0")]
			public string core_url;

			// Token: 0x0400FAFC RID: 64252
			[Token(Token = "0x400FAFC")]
			[FieldOffset(Offset = "0xF8")]
			public string[] core_ip_list;

			// Token: 0x0400FAFD RID: 64253
			[Token(Token = "0x400FAFD")]
			[FieldOffset(Offset = "0x100")]
			public bool is_update_btn_show;
		}

		// Token: 0x020025EF RID: 9711
		[Token(Token = "0x20025EF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF0C", Offset = "0x10FDF0C")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x0600C88B RID: 51339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C88B")]
			[Address(RVA = "0x1EA0D48", Offset = "0x1EA0D48", VA = "0x7BBC6A0D48")]
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x0600C88C RID: 51340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C88C")]
			[Address(RVA = "0x1EA19BC", Offset = "0x1EA19BC", VA = "0x7BBC6A19BC")]
			internal void <CheckVersion>b__3()
			{
			}

			// Token: 0x0400FAFE RID: 64254
			[Token(Token = "0x400FAFE")]
			[FieldOffset(Offset = "0x10")]
			public float toMB;

			// Token: 0x0400FAFF RID: 64255
			[Token(Token = "0x400FAFF")]
			[FieldOffset(Offset = "0x18")]
			public UILauncherController <>4__this;
		}

		// Token: 0x020025F0 RID: 9712
		[Token(Token = "0x20025F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF1C", Offset = "0x10FDF1C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600C88E RID: 51342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C88E")]
			[Address(RVA = "0x1EA19AC", Offset = "0x1EA19AC", VA = "0x7BBC6A19AC")]
			public <>c()
			{
			}

			// Token: 0x0600C88F RID: 51343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C88F")]
			[Address(RVA = "0x1EA19B4", Offset = "0x1EA19B4", VA = "0x7BBC6A19B4")]
			internal void <CheckVersion>b__36_4()
			{
			}

			// Token: 0x0400FB00 RID: 64256
			[Token(Token = "0x400FB00")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILauncherController.<>c <>9;

			// Token: 0x0400FB01 RID: 64257
			[Token(Token = "0x400FB01")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__36_4;
		}

		// Token: 0x020025F1 RID: 9713
		[Token(Token = "0x20025F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF2C", Offset = "0x10FDF2C")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x0600C890 RID: 51344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C890")]
			[Address(RVA = "0x1EA1940", Offset = "0x1EA1940", VA = "0x7BBC6A1940")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0600C891 RID: 51345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C891")]
			[Address(RVA = "0x1EA1A38", Offset = "0x1EA1A38", VA = "0x7BBC6A1A38")]
			internal void <OnHotUpdateFinished>b__2()
			{
			}

			// Token: 0x0400FB02 RID: 64258
			[Token(Token = "0x400FB02")]
			[FieldOffset(Offset = "0x10")]
			public float toMB;

			// Token: 0x0400FB03 RID: 64259
			[Token(Token = "0x400FB03")]
			[FieldOffset(Offset = "0x18")]
			public UILauncherController <>4__this;
		}

		// Token: 0x020025F2 RID: 9714
		[Token(Token = "0x20025F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF3C", Offset = "0x10FDF3C")]
		private sealed class <StartLaunchGame>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C892 RID: 51346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C892")]
			[Address(RVA = "0x1E255A4", Offset = "0x1E255A4", VA = "0x7BBC6255A4")]
			[DebuggerHidden]
			public <StartLaunchGame>d__42(int <>1__state)
			{
			}

			// Token: 0x0600C893 RID: 51347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C893")]
			[Address(RVA = "0x1E255D0", Offset = "0x1E255D0", VA = "0x7BBC6255D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C894 RID: 51348 RVA: 0x000361F8 File Offset: 0x000343F8
			[Token(Token = "0x600C894")]
			[Address(RVA = "0x1E255D4", Offset = "0x1E255D4", VA = "0x7BBC6255D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x0600C895 RID: 51349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D86")]
			private object Current
			{
				[Token(Token = "0x600C895")]
				[Address(RVA = "0x1E257AC", Offset = "0x1E257AC", VA = "0x7BBC6257AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C896 RID: 51350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C896")]
			[Address(RVA = "0x1E257B4", Offset = "0x1E257B4", VA = "0x7BBC6257B4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x0600C897 RID: 51351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D87")]
			private object Current
			{
				[Token(Token = "0x600C897")]
				[Address(RVA = "0x1E2581C", Offset = "0x1E2581C", VA = "0x7BBC62581C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FB04 RID: 64260
			[Token(Token = "0x400FB04")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FB05 RID: 64261
			[Token(Token = "0x400FB05")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FB06 RID: 64262
			[Token(Token = "0x400FB06")]
			[FieldOffset(Offset = "0x20")]
			public UILauncherController <>4__this;
		}

		// Token: 0x020025F3 RID: 9715
		[Token(Token = "0x20025F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF4C", Offset = "0x10FDF4C")]
		private sealed class <StartHotUpdating>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C898 RID: 51352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C898")]
			[Address(RVA = "0x1E253C4", Offset = "0x1E253C4", VA = "0x7BBC6253C4")]
			[DebuggerHidden]
			public <StartHotUpdating>d__43(int <>1__state)
			{
			}

			// Token: 0x0600C899 RID: 51353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C899")]
			[Address(RVA = "0x1E253F0", Offset = "0x1E253F0", VA = "0x7BBC6253F0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C89A RID: 51354 RVA: 0x00036210 File Offset: 0x00034410
			[Token(Token = "0x600C89A")]
			[Address(RVA = "0x1E253F4", Offset = "0x1E253F4", VA = "0x7BBC6253F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x0600C89B RID: 51355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D88")]
			private object Current
			{
				[Token(Token = "0x600C89B")]
				[Address(RVA = "0x1E2552C", Offset = "0x1E2552C", VA = "0x7BBC62552C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C89C RID: 51356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C89C")]
			[Address(RVA = "0x1E25534", Offset = "0x1E25534", VA = "0x7BBC625534", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x0600C89D RID: 51357 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D89")]
			private object Current
			{
				[Token(Token = "0x600C89D")]
				[Address(RVA = "0x1E2559C", Offset = "0x1E2559C", VA = "0x7BBC62559C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FB07 RID: 64263
			[Token(Token = "0x400FB07")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FB08 RID: 64264
			[Token(Token = "0x400FB08")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FB09 RID: 64265
			[Token(Token = "0x400FB09")]
			[FieldOffset(Offset = "0x20")]
			public UILauncherController <>4__this;
		}

		// Token: 0x020025F4 RID: 9716
		[Token(Token = "0x20025F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF5C", Offset = "0x10FDF5C")]
		private sealed class <StartCheckVersion>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C89E RID: 51358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C89E")]
			[Address(RVA = "0x1E9F2FC", Offset = "0x1E9F2FC", VA = "0x7BBC69F2FC")]
			[DebuggerHidden]
			public <StartCheckVersion>d__44(int <>1__state)
			{
			}

			// Token: 0x0600C89F RID: 51359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C89F")]
			[Address(RVA = "0x1EA1AB4", Offset = "0x1EA1AB4", VA = "0x7BBC6A1AB4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C8A0 RID: 51360 RVA: 0x00036228 File Offset: 0x00034428
			[Token(Token = "0x600C8A0")]
			[Address(RVA = "0x1EA1AB8", Offset = "0x1EA1AB8", VA = "0x7BBC6A1AB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x0600C8A1 RID: 51361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D8A")]
			private object Current
			{
				[Token(Token = "0x600C8A1")]
				[Address(RVA = "0x1EA1B60", Offset = "0x1EA1B60", VA = "0x7BBC6A1B60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C8A2 RID: 51362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C8A2")]
			[Address(RVA = "0x1EA1B68", Offset = "0x1EA1B68", VA = "0x7BBC6A1B68", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x0600C8A3 RID: 51363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D8B")]
			private object Current
			{
				[Token(Token = "0x600C8A3")]
				[Address(RVA = "0x1EA1BD0", Offset = "0x1EA1BD0", VA = "0x7BBC6A1BD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FB0A RID: 64266
			[Token(Token = "0x400FB0A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FB0B RID: 64267
			[Token(Token = "0x400FB0B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FB0C RID: 64268
			[Token(Token = "0x400FB0C")]
			[FieldOffset(Offset = "0x20")]
			public UILauncherController <>4__this;
		}

		// Token: 0x020025F5 RID: 9717
		[Token(Token = "0x20025F5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDF6C", Offset = "0x10FDF6C")]
		private sealed class <StartLocDownload>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C8A4 RID: 51364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C8A4")]
			[Address(RVA = "0x1E25824", Offset = "0x1E25824", VA = "0x7BBC625824")]
			[DebuggerHidden]
			public <StartLocDownload>d__45(int <>1__state)
			{
			}

			// Token: 0x0600C8A5 RID: 51365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C8A5")]
			[Address(RVA = "0x1E25850", Offset = "0x1E25850", VA = "0x7BBC625850", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C8A6 RID: 51366 RVA: 0x00036240 File Offset: 0x00034440
			[Token(Token = "0x600C8A6")]
			[Address(RVA = "0x1E25854", Offset = "0x1E25854", VA = "0x7BBC625854", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D8C")]
			private object Current
			{
				[Token(Token = "0x600C8A7")]
				[Address(RVA = "0x1E259AC", Offset = "0x1E259AC", VA = "0x7BBC6259AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C8A8 RID: 51368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C8A8")]
			[Address(RVA = "0x1E259B4", Offset = "0x1E259B4", VA = "0x7BBC6259B4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x0600C8A9 RID: 51369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D8D")]
			private object Current
			{
				[Token(Token = "0x600C8A9")]
				[Address(RVA = "0x1E25A1C", Offset = "0x1E25A1C", VA = "0x7BBC625A1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400FB0D RID: 64269
			[Token(Token = "0x400FB0D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400FB0E RID: 64270
			[Token(Token = "0x400FB0E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400FB0F RID: 64271
			[Token(Token = "0x400FB0F")]
			[FieldOffset(Offset = "0x20")]
			public UILauncherController <>4__this;
		}
	}
}
