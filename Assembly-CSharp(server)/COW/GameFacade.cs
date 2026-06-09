using System;
using System.Collections.Generic;
using COW.Gameplay;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001253 RID: 4691
	[Token(Token = "0x2001253")]
	internal class GameFacade
	{
		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x00015708 File Offset: 0x00013908
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000831")]
		public static bool UseBooyahEmote
		{
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x1874A20", Offset = "0x1874A20", VA = "0x7BBC074A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047E6")]
			[Address(RVA = "0x1874AA0", Offset = "0x1874AA0", VA = "0x7BBC074AA0")]
			set
			{
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x17000832")]
		public static bool IsDebtUser
		{
			[Token(Token = "0x60047E7")]
			[Address(RVA = "0x1874B3C", Offset = "0x1874B3C", VA = "0x7BBC074B3C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x00015738 File Offset: 0x00013938
		// (set) Token: 0x060047E9 RID: 18409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000833")]
		public static bool IsAddicticUser
		{
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x1874BE4", Offset = "0x1874BE4", VA = "0x7BBC074BE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047E9")]
			[Address(RVA = "0x1874C4C", Offset = "0x1874C4C", VA = "0x7BBC074C4C")]
			set
			{
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x00015750 File Offset: 0x00013950
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000834")]
		public static bool IsAddicticMatchUser
		{
			[Token(Token = "0x60047EA")]
			[Address(RVA = "0x1874CBC", Offset = "0x1874CBC", VA = "0x7BBC074CBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x1874D24", Offset = "0x1874D24", VA = "0x7BBC074D24")]
			set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x00015768 File Offset: 0x00013968
		// (set) Token: 0x060047ED RID: 18413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000835")]
		public static bool PopEvents
		{
			[Token(Token = "0x60047EC")]
			[Address(RVA = "0x1874D94", Offset = "0x1874D94", VA = "0x7BBC074D94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBE0", Offset = "0x113DBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047ED")]
			[Address(RVA = "0x1874DFC", Offset = "0x1874DFC", VA = "0x7BBC074DFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBF0", Offset = "0x113DBF0")]
			private set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060047EE RID: 18414 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x17000836")]
		public static bool IsUsePCWaitingRoomRankUI
		{
			[Token(Token = "0x60047EE")]
			[Address(RVA = "0x1874E6C", Offset = "0x1874E6C", VA = "0x7BBC074E6C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x1874ED4", Offset = "0x1874ED4", VA = "0x7BBC074ED4")]
		public static void Cleanup()
		{
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x1874F68", Offset = "0x1874F68", VA = "0x7BBC074F68")]
		public static void SetCurrentGame(BaseGame game)
		{
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F1")]
		[Address(RVA = "0x1866848", Offset = "0x1866848", VA = "0x7BBC066848")]
		public static UICOWBaseScene CurrentUIScene()
		{
			return null;
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x1874FD4", Offset = "0x1874FD4", VA = "0x7BBC074FD4")]
		public static UIInGameScene CurrentInGameUIScene()
		{
			return null;
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x1875074", Offset = "0x1875074", VA = "0x7BBC075074")]
		public static TimeService CurrentGameTimer()
		{
			return null;
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x18750F0", Offset = "0x18750F0", VA = "0x7BBC0750F0")]
		public static EventDispatcher CurrentGameEventDispatcher()
		{
			return null;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x187516C", Offset = "0x187516C", VA = "0x7BBC07516C")]
		public static TimeService CurrentGameSimulationTimer()
		{
			return null;
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x18751E8", Offset = "0x18751E8", VA = "0x7BBC0751E8")]
		public static float CurrentGameFixedDeltaTime()
		{
			return 0f;
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x187527C", Offset = "0x187527C", VA = "0x7BBC07527C")]
		public static Y CurrentLevelObjectManager()
		{
			return null;
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F8")]
		[Address(RVA = "0x18753D4", Offset = "0x18753D4", VA = "0x7BBC0753D4")]
		public static GameModeSetting CurrentGameModeSetting()
		{
			return null;
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x60047F9")]
		[Address(RVA = "0x1875514", Offset = "0x1875514", VA = "0x7BBC075514")]
		public static bool IsGamePaused()
		{
			return default(bool);
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047FA")]
		[Address(RVA = "0x1875654", Offset = "0x1875654", VA = "0x7BBC075654")]
		public static ContainerDatas CurrentGameContainerDatas()
		{
			return null;
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047FB")]
		[Address(RVA = "0x1875794", Offset = "0x1875794", VA = "0x7BBC075794")]
		public static <<EMPTY_NAME>> CurrentMatch()
		{
			return null;
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x60047FC")]
		[Address(RVA = "0x18758EC", Offset = "0x18758EC", VA = "0x7BBC0758EC")]
		public static ulong GetLocalPlayerUserID()
		{
			return 0UL;
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047FD")]
		[Address(RVA = "0x1875954", Offset = "0x1875954", VA = "0x7BBC075954")]
		public static AbDr`s CurrentLocalPawn()
		{
			return null;
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047FE")]
		[Address(RVA = "0x1876038", Offset = "0x1876038", VA = "0x7BBC076038")]
		public static Player GetLocalPlayerOrObServer()
		{
			return null;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047FF")]
		[Address(RVA = "0x18759FC", Offset = "0x18759FC", VA = "0x7BBC0759FC")]
		public static Player CurrentLocalPlayer()
		{
			return null;
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004800")]
		[Address(RVA = "0x18765F0", Offset = "0x18765F0", VA = "0x7BBC0765F0")]
		public static PlayerWereWolves CurrentLocalWereWolvesPlayer()
		{
			return null;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004801")]
		[Address(RVA = "0x1876690", Offset = "0x1876690", VA = "0x7BBC076690")]
		public static Player CurrentLocalPlayerWithPending()
		{
			return null;
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x6004802")]
		[Address(RVA = "0x18768C8", Offset = "0x18768C8", VA = "0x7BBC0768C8")]
		public static {QAb\u0082~u CurrentLocalPlayerID()
		{
			return default({QAb\u0082~u);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x1875C10", Offset = "0x1875C10", VA = "0x7BBC075C10")]
		public static Vutsono CurrentLocalObserver()
		{
			return null;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004804")]
		[Address(RVA = "0x1875E24", Offset = "0x1875E24", VA = "0x7BBC075E24")]
		public static hxgtqc~ CurrentLocalSpectator()
		{
			return null;
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004805")]
		[Address(RVA = "0x1876B18", Offset = "0x1876B18", VA = "0x7BBC076B18")]
		public static Player GetLocalPlayerOrObserverTarget()
		{
			return null;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x6004806")]
		[Address(RVA = "0x1876C4C", Offset = "0x1876C4C", VA = "0x7BBC076C4C")]
		public static bool IsSameTeam(Player p1, Player p2)
		{
			return default(bool);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x6004807")]
		[Address(RVA = "0x1876D90", Offset = "0x1876D90", VA = "0x7BBC076D90")]
		public static bool IsSameTeam({QAb\u0082~u p1, {QAb\u0082~u p2)
		{
			return default(bool);
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004808")]
		[Address(RVA = "0x187619C", Offset = "0x187619C", VA = "0x7BBC07619C")]
		public static pwhmNKy CurrentLocalFixedObserverEntity()
		{
			return null;
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x6004809")]
		[Address(RVA = "0x1876DCC", Offset = "0x1876DCC", VA = "0x7BBC076DCC")]
		public static float GetRevisedValueByFPS(float v, float deltaTime)
		{
			return 0f;
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x600480A")]
		[Address(RVA = "0x1876DE0", Offset = "0x1876DE0", VA = "0x7BBC076DE0")]
		public static float GetRevisedValueBySystemFPS(float v)
		{
			return 0f;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x600480B")]
		[Address(RVA = "0x1876E64", Offset = "0x1876E64", VA = "0x7BBC076E64")]
		public static bool IsOnlineGame()
		{
			return default(bool);
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x00015870 File Offset: 0x00013A70
		[Token(Token = "0x600480C")]
		[Address(RVA = "0x1876FA4", Offset = "0x1876FA4", VA = "0x7BBC076FA4")]
		public static bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
		{
			return default(bool);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600480D")]
		[Address(RVA = "0x187706C", Offset = "0x187706C", VA = "0x7BBC07706C")]
		public static MatchGameClient CurretOnlineMatchClient()
		{
			return null;
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x00015888 File Offset: 0x00013A88
		[Token(Token = "0x600480E")]
		[Address(RVA = "0x18771B0", Offset = "0x18771B0", VA = "0x7BBC0771B0")]
		public static float CurrentServerTime()
		{
			return 0f;
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x000158A0 File Offset: 0x00013AA0
		[Token(Token = "0x600480F")]
		[Address(RVA = "0x1877320", Offset = "0x1877320", VA = "0x7BBC077320")]
		public static uint CurrentServerTick()
		{
			return 0U;
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004810")]
		[Address(RVA = "0x1877490", Offset = "0x1877490", VA = "0x7BBC077490")]
		public static CameraControllerManager CurrentCameraControllerManager()
		{
			return null;
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004811")]
		[Address(RVA = "0x18775E8", Offset = "0x18775E8", VA = "0x7BBC0775E8")]
		public static void EventsPopupDone()
		{
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x000158B8 File Offset: 0x00013AB8
		[Token(Token = "0x6004812")]
		[Address(RVA = "0x1877648", Offset = "0x1877648", VA = "0x7BBC077648")]
		public static bool CheckUseNoBlood()
		{
			return default(bool);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x000158D0 File Offset: 0x00013AD0
		[Token(Token = "0x6004813")]
		[Address(RVA = "0x18777A4", Offset = "0x18777A4", VA = "0x7BBC0777A4")]
		public static int NeedSyncShowBloodOption()
		{
			return 0;
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x6004814")]
		[Address(RVA = "0x1877B3C", Offset = "0x1877B3C", VA = "0x7BBC077B3C")]
		public static bool NeedShowBloodOption()
		{
			return default(bool);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00015900 File Offset: 0x00013B00
		[Token(Token = "0x6004815")]
		[Address(RVA = "0x187804C", Offset = "0x187804C", VA = "0x7BBC07804C")]
		public static bool DefaultBloodIsBlack()
		{
			return default(bool);
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x6004816")]
		[Address(RVA = "0x1878054", Offset = "0x1878054", VA = "0x7BBC078054")]
		public static BloodType GetCurrentBloodType(bool pcIgnoreBloodSwitch = false)
		{
			return BloodType.Red;
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x6004817")]
		[Address(RVA = "0x1878144", Offset = "0x1878144", VA = "0x7BBC078144")]
		public static BloodType GetCurrentSafeZoneDmgEffectType(bool pcIgnoreBloodSwitch = false)
		{
			return BloodType.Red;
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004818")]
		[Address(RVA = "0x1878234", Offset = "0x1878234", VA = "0x7BBC078234")]
		public static void SetCurrentUseBlackBlood(BloodType booldType)
		{
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x6004819")]
		[Address(RVA = "0x18783B0", Offset = "0x18783B0", VA = "0x7BBC0783B0")]
		public static bool GetBloodVisibility()
		{
			return default(bool);
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x600481A")]
		[Address(RVA = "0x1878458", Offset = "0x1878458", VA = "0x7BBC078458")]
		public static bool GetSafeZoneDmgEffectVisibility()
		{
			return default(bool);
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481B")]
		[Address(RVA = "0x1878500", Offset = "0x1878500", VA = "0x7BBC078500")]
		public static void SetBloodVisibility(bool visibility)
		{
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481C")]
		[Address(RVA = "0x18785F0", Offset = "0x18785F0", VA = "0x7BBC0785F0")]
		public static void SetDamageLabelType(int type)
		{
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00015978 File Offset: 0x00013B78
		[Token(Token = "0x600481D")]
		[Address(RVA = "0x1878690", Offset = "0x1878690", VA = "0x7BBC078690")]
		public static int GetDamageLabelType()
		{
			return 0;
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481E")]
		[Address(RVA = "0x187872C", Offset = "0x187872C", VA = "0x7BBC07872C")]
		public static void SetSafeZoneDmgEffectVisibility(bool visibility)
		{
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481F")]
		[Address(RVA = "0x187881C", Offset = "0x187881C", VA = "0x7BBC07881C")]
		public static void LoadMPBattleGame(GameFacade.EMPConnectionType connType)
		{
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004820")]
		[Address(RVA = "0x18799E4", Offset = "0x18799E4", VA = "0x7BBC0799E4")]
		public static void LoadMPWaitingGame()
		{
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004821")]
		public static HttpRequest SendServerRequest<T>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0U, bool encrypt = true)
		{
			return null;
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x1879AFC", Offset = "0x1879AFC", VA = "0x7BBC079AFC")]
		public static bool IsCSRanking()
		{
			return default(bool);
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x6004823")]
		[Address(RVA = "0x1879B6C", Offset = "0x1879B6C", VA = "0x7BBC079B6C")]
		public static bool IsCustomRoom()
		{
			return default(bool);
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x6004824")]
		[Address(RVA = "0x1879BDC", Offset = "0x1879BDC", VA = "0x7BBC079BDC")]
		public static bool IsCustomRoomCasual()
		{
			return default(bool);
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x1879C74", Offset = "0x1879C74", VA = "0x7BBC079C74")]
		public static bool IsCustomRoomLeague()
		{
			return default(bool);
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x1879D0C", Offset = "0x1879D0C", VA = "0x7BBC079D0C")]
		public static bool IsSpectatorOrCreator()
		{
			return default(bool);
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x1879DD4", Offset = "0x1879DD4", VA = "0x7BBC079DD4")]
		public static bool IsBattleRoyale()
		{
			return default(bool);
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x6004828")]
		[Address(RVA = "0x1879E44", Offset = "0x1879E44", VA = "0x7BBC079E44")]
		public static bool IsSpeedMode()
		{
			return default(bool);
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x6004829")]
		[Address(RVA = "0x1879EE4", Offset = "0x1879EE4", VA = "0x7BBC079EE4")]
		public static bool IsHyakkiMode()
		{
			return default(bool);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x1879F54", Offset = "0x1879F54", VA = "0x7BBC079F54")]
		public static bool UseNewDeathCamera()
		{
			return default(bool);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x600482B")]
		[Address(RVA = "0x187A09C", Offset = "0x187A09C", VA = "0x7BBC07A09C")]
		public static bool IsRebornMode()
		{
			return default(bool);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00015A80 File Offset: 0x00013C80
		[Token(Token = "0x600482C")]
		[Address(RVA = "0x187A10C", Offset = "0x187A10C", VA = "0x7BBC07A10C")]
		public static bool IsCSMode()
		{
			return default(bool);
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00015A98 File Offset: 0x00013C98
		[Token(Token = "0x600482D")]
		[Address(RVA = "0x187A17C", Offset = "0x187A17C", VA = "0x7BBC07A17C")]
		public static bool IsFateRoyaleMode()
		{
			return default(bool);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[Token(Token = "0x600482E")]
		[Address(RVA = "0x187A1EC", Offset = "0x187A1EC", VA = "0x7BBC07A1EC")]
		public static bool IsFateRoyaleFastMode()
		{
			return default(bool);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x00015AC8 File Offset: 0x00013CC8
		[Token(Token = "0x600482F")]
		[Address(RVA = "0x187A25C", Offset = "0x187A25C", VA = "0x7BBC07A25C")]
		public static bool IsTKMode()
		{
			return default(bool);
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[Token(Token = "0x6004830")]
		[Address(RVA = "0x187A2CC", Offset = "0x187A2CC", VA = "0x7BBC07A2CC")]
		public static bool IsTDMMode()
		{
			return default(bool);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00015AF8 File Offset: 0x00013CF8
		[Token(Token = "0x6004831")]
		[Address(RVA = "0x187A33C", Offset = "0x187A33C", VA = "0x7BBC07A33C")]
		public static bool IsTokenMode()
		{
			return default(bool);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00015B10 File Offset: 0x00013D10
		[Token(Token = "0x6004832")]
		[Address(RVA = "0x187A3AC", Offset = "0x187A3AC", VA = "0x7BBC07A3AC")]
		public static bool IsGiantMode()
		{
			return default(bool);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x6004833")]
		[Address(RVA = "0x187A41C", Offset = "0x187A41C", VA = "0x7BBC07A41C")]
		public static bool IsArmsRaceMode()
		{
			return default(bool);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x6004834")]
		[Address(RVA = "0x187A48C", Offset = "0x187A48C", VA = "0x7BBC07A48C")]
		public static bool IsArmsRaceTeamMode()
		{
			return default(bool);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x6004835")]
		[Address(RVA = "0x187A4FC", Offset = "0x187A4FC", VA = "0x7BBC07A4FC")]
		public static bool IsReaperMode()
		{
			return default(bool);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x6004836")]
		[Address(RVA = "0x187A56C", Offset = "0x187A56C", VA = "0x7BBC07A56C")]
		public static bool IsBombMode()
		{
			return default(bool);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x187A5DC", Offset = "0x187A5DC", VA = "0x7BBC07A5DC")]
		public static bool IsKJPMode()
		{
			return default(bool);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x187A64C", Offset = "0x187A64C", VA = "0x7BBC07A64C")]
		public static bool IsTrainingMode()
		{
			return default(bool);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x6004839")]
		[Address(RVA = "0x187A6BC", Offset = "0x187A6BC", VA = "0x7BBC07A6BC")]
		public static bool IsWinnerTakeAllMode()
		{
			return default(bool);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Token(Token = "0x600483A")]
		[Address(RVA = "0x187A72C", Offset = "0x187A72C", VA = "0x7BBC07A72C")]
		public static bool IsHypeRelatedMode()
		{
			return default(bool);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[Token(Token = "0x600483B")]
		[Address(RVA = "0x187A7B8", Offset = "0x187A7B8", VA = "0x7BBC07A7B8")]
		public static bool IsHypeMode()
		{
			return default(bool);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x600483C")]
		[Address(RVA = "0x187A828", Offset = "0x187A828", VA = "0x7BBC07A828")]
		public static bool IsSnowManMode()
		{
			return default(bool);
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x600483D")]
		[Address(RVA = "0x187A898", Offset = "0x187A898", VA = "0x7BBC07A898")]
		public static bool IsSnowManModeBattleGame()
		{
			return default(bool);
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x600483E")]
		[Address(RVA = "0x187A950", Offset = "0x187A950", VA = "0x7BBC07A950")]
		public static bool IsBigHeadMode()
		{
			return default(bool);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x600483F")]
		[Address(RVA = "0x187A9C0", Offset = "0x187A9C0", VA = "0x7BBC07A9C0")]
		public static bool IsAttackOnHeadMode()
		{
			return default(bool);
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x187AA30", Offset = "0x187AA30", VA = "0x7BBC07AA30")]
		public static bool IsDGGMode()
		{
			return default(bool);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x187AAA0", Offset = "0x187AAA0", VA = "0x7BBC07AAA0")]
		public static bool IsControlMode()
		{
			return default(bool);
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x187AB10", Offset = "0x187AB10", VA = "0x7BBC07AB10")]
		public static bool IsCSStrikeOutMode()
		{
			return default(bool);
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x6004843")]
		[Address(RVA = "0x187AB80", Offset = "0x187AB80", VA = "0x7BBC07AB80")]
		public static bool IsBanknoteMode()
		{
			return default(bool);
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x6004844")]
		[Address(RVA = "0x187ABF0", Offset = "0x187ABF0", VA = "0x7BBC07ABF0")]
		public static bool IsADSMode()
		{
			return default(bool);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x6004845")]
		[Address(RVA = "0x187AC60", Offset = "0x187AC60", VA = "0x7BBC07AC60")]
		public static bool IsWereWolvesMode()
		{
			return default(bool);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x6004846")]
		[Address(RVA = "0x187ACD0", Offset = "0x187ACD0", VA = "0x7BBC07ACD0")]
		public static bool IsSkyDivingRevive()
		{
			return default(bool);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x6004847")]
		[Address(RVA = "0x187AD7C", Offset = "0x187AD7C", VA = "0x7BBC07AD7C")]
		public static bool IsPlayerReadyNeedDelay()
		{
			return default(bool);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x6004848")]
		[Address(RVA = "0x187AF30", Offset = "0x187AF30", VA = "0x7BBC07AF30")]
		public static bool GameModeSupportRevive()
		{
			return default(bool);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004849")]
		[Address(RVA = "0x187AFD0", Offset = "0x187AFD0", VA = "0x7BBC07AFD0")]
		public static void SetFrameRate(int frameRate)
		{
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x600484A")]
		[Address(RVA = "0x187B08C", Offset = "0x187B08C", VA = "0x7BBC07B08C")]
		public static int GetFrameRate()
		{
			return 0;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x187B094", Offset = "0x187B094", VA = "0x7BBC07B094")]
		public static bool IsNoWaitingRoomGame()
		{
			return default(bool);
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x187B1C4", Offset = "0x187B1C4", VA = "0x7BBC07B1C4")]
		public static bool IsNoSafeZone()
		{
			return default(bool);
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x187B278", Offset = "0x187B278", VA = "0x7BBC07B278")]
		public static bool IsNoJumping()
		{
			return default(bool);
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x600484E")]
		[Address(RVA = "0x187B32C", Offset = "0x187B32C", VA = "0x7BBC07B32C")]
		public static bool IsGameSafeZoneIgnoreFirstOne()
		{
			return default(bool);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x600484F")]
		[Address(RVA = "0x187B46C", Offset = "0x187B46C", VA = "0x7BBC07B46C")]
		public static bool ShowGuideToSafeZone()
		{
			return default(bool);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004850")]
		[Address(RVA = "0x187B5DC", Offset = "0x187B5DC", VA = "0x7BBC07B5DC")]
		public static InGameCutsceneManager CurrentInGameCutsceneManager()
		{
			return null;
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004851")]
		[Address(RVA = "0x187B734", Offset = "0x187B734", VA = "0x7BBC07B734")]
		public static void RegisterInGameCutsceneManager(InGameCutsceneManager manager)
		{
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004852")]
		[Address(RVA = "0x187B890", Offset = "0x187B890", VA = "0x7BBC07B890")]
		public static void PlayUIBlackMaskAnim(EMaskAnimType animType, float fadeDuration, float lightDuration, float stableDuration, bool disableMaskAfterFinished = true)
		{
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x6004853")]
		[Address(RVA = "0x187BB64", Offset = "0x187BB64", VA = "0x7BBC07BB64")]
		public static bool IsBossByType(LKBHVE} aiType)
		{
			return default(bool);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x6004854")]
		[Address(RVA = "0x187BB8C", Offset = "0x187BB8C", VA = "0x7BBC07BB8C")]
		public static bool IsUnlimitedAmmo()
		{
			return default(bool);
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x00015DF8 File Offset: 0x00013FF8
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		public static uint ResourceLoadCount
		{
			[Token(Token = "0x6004855")]
			[Address(RVA = "0x187BCCC", Offset = "0x187BCCC", VA = "0x7BBC07BCCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC00", Offset = "0x113DC00")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004856")]
			[Address(RVA = "0x187BD34", Offset = "0x187BD34", VA = "0x7BBC07BD34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC10", Offset = "0x113DC10")]
			set
			{
			}
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x6004857")]
		[Address(RVA = "0x187BDA0", Offset = "0x187BDA0", VA = "0x7BBC07BDA0")]
		public static bool IsFateRoyalMode(uint mode)
		{
			return default(bool);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00015E28 File Offset: 0x00014028
		[Token(Token = "0x6004858")]
		[Address(RVA = "0x187BDE0", Offset = "0x187BDE0", VA = "0x7BBC07BDE0")]
		public static bool HasPlayedFirstGame()
		{
			return default(bool);
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004859")]
		[Address(RVA = "0x187BF0C", Offset = "0x187BF0C", VA = "0x7BBC07BF0C")]
		public static void PlayFirstGame()
		{
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x600485A")]
		[Address(RVA = "0x187C030", Offset = "0x187C030", VA = "0x7BBC07C030")]
		public static bool HasFirstGameLand()
		{
			return default(bool);
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485B")]
		[Address(RVA = "0x187C15C", Offset = "0x187C15C", VA = "0x7BBC07C15C")]
		public static void FirstGameLand()
		{
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485C")]
		[Address(RVA = "0x187C280", Offset = "0x187C280", VA = "0x7BBC07C280")]
		public static void UpdateOpeningMovieRegion()
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00015E58 File Offset: 0x00014058
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x187C39C", Offset = "0x187C39C", VA = "0x7BBC07C39C")]
		public static bool IsOpeningMovieRegionEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x600485E")]
		[Address(RVA = "0x187C404", Offset = "0x187C404", VA = "0x7BBC07C404")]
		public static float GetFakePingInRegion()
		{
			return 0f;
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00015E88 File Offset: 0x00014088
		[Token(Token = "0x600485F")]
		[Address(RVA = "0x187C754", Offset = "0x187C754", VA = "0x7BBC07C754")]
		public static bool IsSonoranMap()
		{
			return default(bool);
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00015EA0 File Offset: 0x000140A0
		[Token(Token = "0x6004860")]
		[Address(RVA = "0x187C7C4", Offset = "0x187C7C4", VA = "0x7BBC07C7C4")]
		public static bool IsParadiseNeoMap()
		{
			return default(bool);
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x187C834", Offset = "0x187C834", VA = "0x7BBC07C834")]
		public static List<COW.GamePlay.YmQ\u0082E\u007FN> GetArmsRaceInfo()
		{
			return null;
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x187C918", Offset = "0x187C918", VA = "0x7BBC07C918")]
		public static ResourceID GetWeaponIconByArmsLevel(int armsLevel)
		{
			return default(ResourceID);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x6004863")]
		[Address(RVA = "0x187CA98", Offset = "0x187CA98", VA = "0x7BBC07CA98")]
		public static bool NeedSyncInfoInTrainingMode({QAb\u0082~u fromPlayerID)
		{
			return default(bool);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x187CC44", Offset = "0x187CC44", VA = "0x7BBC07CC44")]
		public static bool NeedSyncInfoInTrainingMode()
		{
			return default(bool);
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x6004865")]
		[Address(RVA = "0x187CD44", Offset = "0x187CD44", VA = "0x7BBC07CD44")]
		public static bool IsTrainingSubZone({Z|h[YF z)
		{
			return default(bool);
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004866")]
		[Address(RVA = "0x187CD54", Offset = "0x187CD54", VA = "0x7BBC07CD54")]
		public static void SetUIRootOnAwake(Action<UIRoot> onAwake)
		{
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004867")]
		[Address(RVA = "0x187CDC0", Offset = "0x187CDC0", VA = "0x7BBC07CDC0")]
		public static zq|Dsh{ GetSingleBountyWaitingGame()
		{
			return null;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x6004868")]
		[Address(RVA = "0x187CE68", Offset = "0x187CE68", VA = "0x7BBC07CE68")]
		public static bool IsSingleBountyWaitingGame()
		{
			return default(bool);
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x187CF10", Offset = "0x187CF10", VA = "0x7BBC07CF10")]
		public static bool IsSinglBountyLowMemory()
		{
			return default(bool);
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x187CFB4", Offset = "0x187CFB4", VA = "0x7BBC07CFB4")]
		public static void SetSingleBountyWaitingPlayPre()
		{
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x187D004", Offset = "0x187D004", VA = "0x7BBC07D004")]
		public static bool IsPlayedSingleBountyWaiting()
		{
			return default(bool);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x187D05C", Offset = "0x187D05C", VA = "0x7BBC07D05C")]
		public static bool IsBountGameIgnoreOneShotSound()
		{
			return default(bool);
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x600486D")]
		[Address(RVA = "0x187D0FC", Offset = "0x187D0FC", VA = "0x7BBC07D0FC")]
		public static bool IsMultipleBountyWaiting()
		{
			return default(bool);
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486E")]
		[Address(RVA = "0x187D1A4", Offset = "0x187D1A4", VA = "0x7BBC07D1A4")]
		public static IFTr^bK GetMultipleBountyWaiting()
		{
			return null;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x187D24C", Offset = "0x187D24C", VA = "0x7BBC07D24C")]
		public static void LoadAndRunSinglePlayerGameBountyWaiting()
		{
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x6004870")]
		[Address(RVA = "0x187D250", Offset = "0x187D250", VA = "0x7BBC07D250")]
		public static bool IsWereWolvesGame()
		{
			return default(bool);
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004871")]
		[Address(RVA = "0x187D2F8", Offset = "0x187D2F8", VA = "0x7BBC07D2F8")]
		public static MultiplePlayerWereWolvesGame GetWereWolvesGame()
		{
			return null;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004872")]
		[Address(RVA = "0x187D3A0", Offset = "0x187D3A0", VA = "0x7BBC07D3A0")]
		public static UIWereWolvesGameScene GetWereWolvesGameUIScene()
		{
			return null;
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004873")]
		[Address(RVA = "0x187D440", Offset = "0x187D440", VA = "0x7BBC07D440")]
		public static PlayerWereWolves GetLocalWereWolvesPlayer()
		{
			return null;
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004874")]
		[Address(RVA = "0x187D4E0", Offset = "0x187D4E0", VA = "0x7BBC07D4E0")]
		public static WereWolvesBodyManager GetWereWolvesBodyManager()
		{
			return null;
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x6004875")]
		[Address(RVA = "0x187D554", Offset = "0x187D554", VA = "0x7BBC07D554")]
		public static Color GetWereWolveColorByIndex(int index)
		{
			return default(Color);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x187D618", Offset = "0x187D618", VA = "0x7BBC07D618")]
		public static WereWolvesRoleData GetWereWolveRoleInfoByIndex(int index)
		{
			return null;
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x187D6C8", Offset = "0x187D6C8", VA = "0x7BBC07D6C8")]
		public static M\u0081 GetWereWolvesGameOverState()
		{
			return M\u0081.EWereWolvesGameOverState_NoOver;
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004878")]
		[Address(RVA = "0x187D73C", Offset = "0x187D73C", VA = "0x7BBC07D73C")]
		public static qxPLSvi GetWereWolvesGameMatchEndInfo()
		{
			return null;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x6004879")]
		[Address(RVA = "0x187D7B0", Offset = "0x187D7B0", VA = "0x7BBC07D7B0")]
		public static int GetWereWolveVoteCenterCDEndTimeMS()
		{
			return 0;
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487A")]
		[Address(RVA = "0x187D824", Offset = "0x187D824", VA = "0x7BBC07D824")]
		public GameFacade()
		{
		}

		// Token: 0x0400716C RID: 29036
		[Token(Token = "0x400716C")]
		[FieldOffset(Offset = "0x0")]
		public static BaseGame CurrentGame;

		// Token: 0x0400716D RID: 29037
		[Token(Token = "0x400716D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string KEY_IS_BLACK_BLOOD;

		// Token: 0x0400716E RID: 29038
		[Token(Token = "0x400716E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string KEY_CUSTOMROOM_IS_BLOOD_SHOW;

		// Token: 0x0400716F RID: 29039
		[Token(Token = "0x400716F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string KEY_CUSTOMROOM_IS_SAFEZONE_DAMAGE_EFFECT_SHOW;

		// Token: 0x04007170 RID: 29040
		[Token(Token = "0x4007170")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string KEY_DEMAGE_LABELTYPE;

		// Token: 0x04007171 RID: 29041
		[Token(Token = "0x4007171")]
		[FieldOffset(Offset = "0x28")]
		private static BloodType m_bloodType;

		// Token: 0x04007172 RID: 29042
		[Token(Token = "0x4007172")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly bool IsPCClient;

		// Token: 0x04007173 RID: 29043
		[Token(Token = "0x4007173")]
		[FieldOffset(Offset = "0x30")]
		public static ulong LocalPlayerUserID;

		// Token: 0x04007174 RID: 29044
		[Token(Token = "0x4007174")]
		[FieldOffset(Offset = "0x38")]
		public static byte RegionID;

		// Token: 0x04007175 RID: 29045
		[Token(Token = "0x4007175")]
		[FieldOffset(Offset = "0x40")]
		public static string RegionName;

		// Token: 0x04007176 RID: 29046
		[Token(Token = "0x4007176")]
		[FieldOffset(Offset = "0x48")]
		public static bool OfflineMode;

		// Token: 0x04007177 RID: 29047
		[Token(Token = "0x4007177")]
		[FieldOffset(Offset = "0x50")]
		public static string GameServerAddr;

		// Token: 0x04007178 RID: 29048
		[Token(Token = "0x4007178")]
		[FieldOffset(Offset = "0x58")]
		public static int GameServerPort;

		// Token: 0x04007179 RID: 29049
		[Token(Token = "0x4007179")]
		[FieldOffset(Offset = "0x60")]
		public static ulong GameServerMatchID;

		// Token: 0x0400717A RID: 29050
		[Token(Token = "0x400717A")]
		[FieldOffset(Offset = "0x68")]
		public static ulong GameServerServiceMatchID;

		// Token: 0x0400717B RID: 29051
		[Token(Token = "0x400717B")]
		[FieldOffset(Offset = "0x70")]
		public static string GameServerToken;

		// Token: 0x0400717C RID: 29052
		[Token(Token = "0x400717C")]
		[FieldOffset(Offset = "0x78")]
		public static string GameServerSecretKey;

		// Token: 0x0400717D RID: 29053
		[Token(Token = "0x400717D")]
		[FieldOffset(Offset = "0x80")]
		public static uint GameServerMapID;

		// Token: 0x0400717E RID: 29054
		[Token(Token = "0x400717E")]
		[FieldOffset(Offset = "0x84")]
		public static uint GameServerGameMode;

		// Token: 0x0400717F RID: 29055
		[Token(Token = "0x400717F")]
		[FieldOffset(Offset = "0x88")]
		public static uint GameServerMatchMode;

		// Token: 0x04007180 RID: 29056
		[Token(Token = "0x4007180")]
		[FieldOffset(Offset = "0x8C")]
		public static uint GameServerGroupMode;

		// Token: 0x04007181 RID: 29057
		[Token(Token = "0x4007181")]
		[FieldOffset(Offset = "0x90")]
		public static uint GameServerRoomRole;

		// Token: 0x04007182 RID: 29058
		[Token(Token = "0x4007182")]
		[FieldOffset(Offset = "0x94")]
		public static uint GameServerRoomType;

		// Token: 0x04007183 RID: 29059
		[Token(Token = "0x4007183")]
		[FieldOffset(Offset = "0x98")]
		public static bool IsReconnect;

		// Token: 0x04007184 RID: 29060
		[Token(Token = "0x4007184")]
		[FieldOffset(Offset = "0x99")]
		public static bool NeedClearReconnectInfo;

		// Token: 0x04007185 RID: 29061
		[Token(Token = "0x4007185")]
		[FieldOffset(Offset = "0x9A")]
		public static bool IsObserver;

		// Token: 0x04007186 RID: 29062
		[Token(Token = "0x4007186")]
		[FieldOffset(Offset = "0x9C")]
		public static uint LobbyCustomRoomIndex;

		// Token: 0x04007187 RID: 29063
		[Token(Token = "0x4007187")]
		[FieldOffset(Offset = "0xA0")]
		public static uint InGameCustomRoomIndex;

		// Token: 0x04007188 RID: 29064
		[Token(Token = "0x4007188")]
		[FieldOffset(Offset = "0xA4")]
		public static bool IsROGPhone;

		// Token: 0x04007189 RID: 29065
		[Token(Token = "0x4007189")]
		[FieldOffset(Offset = "0xA5")]
		public static bool IsSpecialPool;

		// Token: 0x0400718A RID: 29066
		[Token(Token = "0x400718A")]
		[FieldOffset(Offset = "0xA6")]
		public static bool GameMainSceneLoadedByAb;

		// Token: 0x0400718B RID: 29067
		[Token(Token = "0x400718B")]
		[FieldOffset(Offset = "0xA7")]
		public static bool IsWaitingRoom;

		// Token: 0x0400718C RID: 29068
		[Token(Token = "0x400718C")]
		[FieldOffset(Offset = "0xA8")]
		public static bool IsMatchStarted;

		// Token: 0x0400718D RID: 29069
		[Token(Token = "0x400718D")]
		[FieldOffset(Offset = "0xAC")]
		public static uint LevelVisualStyle;

		// Token: 0x0400718E RID: 29070
		[Token(Token = "0x400718E")]
		[FieldOffset(Offset = "0xB0")]
		private static bool _IsAddicticUser;

		// Token: 0x0400718F RID: 29071
		[Token(Token = "0x400718F")]
		[FieldOffset(Offset = "0xB1")]
		private static bool _IsAddictMatchUser;

		// Token: 0x04007190 RID: 29072
		[Token(Token = "0x4007190")]
		[FieldOffset(Offset = "0xB8")]
		public static string AddicticMessage;

		// Token: 0x04007191 RID: 29073
		[Token(Token = "0x4007191")]
		[FieldOffset(Offset = "0xC0")]
		public static string AddicticBanMessage;

		// Token: 0x04007192 RID: 29074
		[Token(Token = "0x4007192")]
		[FieldOffset(Offset = "0xC8")]
		public static string AddicticTitle;

		// Token: 0x04007193 RID: 29075
		[Token(Token = "0x4007193")]
		[FieldOffset(Offset = "0xD0")]
		public static string AddicticFloating;

		// Token: 0x04007194 RID: 29076
		[Token(Token = "0x4007194")]
		[FieldOffset(Offset = "0xD8")]
		public static ulong AddictAllTime;

		// Token: 0x04007195 RID: 29077
		[Token(Token = "0x4007195")]
		[FieldOffset(Offset = "0xE0")]
		public static ulong AddictMatchTime;

		// Token: 0x04007196 RID: 29078
		[Token(Token = "0x4007196")]
		[FieldOffset(Offset = "0xE8")]
		public static uint AddictAge;

		// Token: 0x04007197 RID: 29079
		[Token(Token = "0x4007197")]
		[FieldOffset(Offset = "0xF0")]
		public static ulong StartTvTime;

		// Token: 0x04007198 RID: 29080
		[Token(Token = "0x4007198")]
		[FieldOffset(Offset = "0xF8")]
		public static ulong FinishTvTime;

		// Token: 0x04007199 RID: 29081
		[Token(Token = "0x4007199")]
		[FieldOffset(Offset = "0x100")]
		public static ulong LastTvTime;

		// Token: 0x0400719A RID: 29082
		[Token(Token = "0x400719A")]
		[FieldOffset(Offset = "0x108")]
		public static uint AgeState;

		// Token: 0x0400719B RID: 29083
		[Token(Token = "0x400719B")]
		[FieldOffset(Offset = "0x10C")]
		public static bool UseBountyWaitingIsland;

		// Token: 0x0400719C RID: 29084
		[Token(Token = "0x400719C")]
		[FieldOffset(Offset = "0x110")]
		public static uint booyahtimes;

		// Token: 0x0400719D RID: 29085
		[Token(Token = "0x400719D")]
		[FieldOffset(Offset = "0x114")]
		public static bool ReleaseLightmapMemoryOnUnloading;

		// Token: 0x0400719E RID: 29086
		[Token(Token = "0x400719E")]
		[FieldOffset(Offset = "0x115")]
		public static bool UnloadEmbeddedSceneObjects;

		// Token: 0x0400719F RID: 29087
		[Token(Token = "0x400719F")]
		[FieldOffset(Offset = "0x116")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F6AC", Offset = "0x112F6AC")]
		private static bool <PopEvents>k__BackingField;

		// Token: 0x040071A0 RID: 29088
		[Token(Token = "0x40071A0")]
		[FieldOffset(Offset = "0x117")]
		private static bool? ShowBloodOption;

		// Token: 0x040071A1 RID: 29089
		[Token(Token = "0x40071A1")]
		[FieldOffset(Offset = "0x119")]
		public static bool IsGroupUIOpen;

		// Token: 0x040071A2 RID: 29090
		[Token(Token = "0x40071A2")]
		[FieldOffset(Offset = "0x11C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F6BC", Offset = "0x112F6BC")]
		private static uint <ResourceLoadCount>k__BackingField;

		// Token: 0x040071A3 RID: 29091
		[Token(Token = "0x40071A3")]
		[FieldOffset(Offset = "0x120")]
		private static bool openingMovieRegionEnable;

		// Token: 0x02001254 RID: 4692
		[Token(Token = "0x2001254")]
		public enum EMPConnectionType
		{
			// Token: 0x040071A5 RID: 29093
			[Token(Token = "0x40071A5")]
			CREATE_NEW_CONN,
			// Token: 0x040071A6 RID: 29094
			[Token(Token = "0x40071A6")]
			REUSE_OLD_CONN
		}

		// Token: 0x02001255 RID: 4693
		[Token(Token = "0x2001255")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB000", Offset = "0x10EB000")]
		private sealed class <>c__DisplayClass121_0<T>
		{
			// Token: 0x0600487C RID: 18556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600487C")]
			public <>c__DisplayClass121_0()
			{
			}

			// Token: 0x0600487D RID: 18557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600487D")]
			internal void <SendServerRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x040071A7 RID: 29095
			[Token(Token = "0x40071A7")]
			[FieldOffset(Offset = "0x0")]
			public Action<HttpErrorCode, object> onFinished;
		}
	}
}
