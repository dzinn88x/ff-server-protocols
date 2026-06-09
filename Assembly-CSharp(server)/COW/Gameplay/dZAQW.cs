using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay
{
	// Token: 0x02002AA5 RID: 10917
	[Token(Token = "0x2002AA5")]
	internal interface dZAQW
	{
		// Token: 0x0600EF4F RID: 61263
		[Token(Token = "0x600EF4F")]
		void PushPlayerSyncedStateData(object QtSZT]E, uint ~||\u0082utT);

		// Token: 0x0600EF50 RID: 61264
		[Token(Token = "0x600EF50")]
		void PushPlayerSyncedOptimizedStateData(object QtSZT]E, uint ~||\u0082utT);

		// Token: 0x0600EF51 RID: 61265
		[Token(Token = "0x600EF51")]
		void PushPlayerSyncedPosition(object zMMMEzr, uint ~||\u0082utT);

		// Token: 0x0600EF52 RID: 61266
		[Token(Token = "0x600EF52")]
		void SyncStartFire(byte yfq{tix);

		// Token: 0x0600EF53 RID: 61267
		[Token(Token = "0x600EF53")]
		void SyncStopFire();

		// Token: 0x0600EF54 RID: 61268
		[Token(Token = "0x600EF54")]
		void SyncStartReload(float \u007FrAkpTo);

		// Token: 0x0600EF55 RID: 61269
		[Token(Token = "0x600EF55")]
		void SyncStopReload(aYKdYWt ~S`Xinb);

		// Token: 0x0600EF56 RID: 61270
		[Token(Token = "0x600EF56")]
		void SyncPickupInventory(~aNqwTz ~S`Xinb);

		// Token: 0x0600EF57 RID: 61271
		[Token(Token = "0x600EF57")]
		void SyncDropInventory([d|TUuD ~S`Xinb);

		// Token: 0x0600EF58 RID: 61272
		[Token(Token = "0x600EF58")]
		void SyncRemoveInventoryList(QJXcFkp ~S`Xinb);

		// Token: 0x0600EF59 RID: 61273
		[Token(Token = "0x600EF59")]
		void SyncEquipmentChanged(]iV\u0082Iys ~S`Xinb);

		// Token: 0x0600EF5A RID: 61274
		[Token(Token = "0x600EF5A")]
		void SyncAttachmentChanged([D~AHNZ ~S`Xinb);

		// Token: 0x0600EF5B RID: 61275
		[Token(Token = "0x600EF5B")]
		void SyncPlayersVisibility(ulong TzzPYjI);

		// Token: 0x0600EF5C RID: 61276
		[Token(Token = "0x600EF5C")]
		void SyncStateWithServer(Jklo[ek ~S`Xinb);

		// Token: 0x0600EF5D RID: 61277
		[Token(Token = "0x600EF5D")]
		void SyncDoAction(xu~ZN~G ~S`Xinb);

		// Token: 0x0600EF5E RID: 61278
		[Token(Token = "0x600EF5E")]
		void SyncTryUseInventory(bool cJldmA{, uint [RDenYe);

		// Token: 0x0600EF5F RID: 61279
		[Token(Token = "0x600EF5F")]
		void SyncLoadoutRuntimeValue(z ~S`Xinb);

		// Token: 0x0600EF60 RID: 61280
		[Token(Token = "0x600EF60")]
		void SyncPlayEmotionAnimation(Nd}{ZeJ ~S`Xinb);

		// Token: 0x0600EF61 RID: 61281
		[Token(Token = "0x600EF61")]
		void SyncKnockDown(pfFZ~uJ ~S`Xinb);

		// Token: 0x0600EF62 RID: 61282
		[Token(Token = "0x600EF62")]
		void SyncRevive(Player.WJA\u0080Xxv D\u0081sKsi^);

		// Token: 0x0600EF63 RID: 61283
		[Token(Token = "0x600EF63")]
		void OnRequestResureTargetRes(fBA\u0082Dje K{\u0080cyv\u007F);

		// Token: 0x0600EF64 RID: 61284
		[Token(Token = "0x600EF64")]
		void OnRequestStopResureTargetRes(eh]CAOW K{\u0080cyv\u007F);

		// Token: 0x0600EF65 RID: 61285
		[Token(Token = "0x600EF65")]
		void RequestFoceSyncPosition();

		// Token: 0x0600EF66 RID: 61286
		[Token(Token = "0x600EF66")]
		void SyncStartGrenade();

		// Token: 0x0600EF67 RID: 61287
		[Token(Token = "0x600EF67")]
		void SyncStopGrenade();

		// Token: 0x0600EF68 RID: 61288
		[Token(Token = "0x600EF68")]
		void SyncTriggerGrenade();

		// Token: 0x0600EF69 RID: 61289
		[Token(Token = "0x600EF69")]
		void SyncInventoryInfo(d[In\u0080AY K{\u0080cyv\u007F);

		// Token: 0x0600EF6A RID: 61290
		[Token(Token = "0x600EF6A")]
		void SyncAttachmentInfo(List<|sqawVc> S~VfzSb);

		// Token: 0x0600EF6B RID: 61291
		[Token(Token = "0x600EF6B")]
		void SyncTeleportInfo(Jklo[ek ~S`Xinb);
	}
}
