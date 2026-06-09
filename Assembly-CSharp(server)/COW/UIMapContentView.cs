using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002430 RID: 9264
	[Token(Token = "0x2002430")]
	public class UIMapContentView : UIBaseView
	{
		// Token: 0x0600C370 RID: 50032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C370")]
		[Address(RVA = "0x146961C", Offset = "0x146961C", VA = "0x7BBBC6961C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C371")]
		[Address(RVA = "0x146AB78", Offset = "0x146AB78", VA = "0x7BBBC6AB78")]
		public UIMapContentView()
		{
		}

		// Token: 0x0400E64F RID: 58959
		[Token(Token = "0x400E64F")]
		[FieldOffset(Offset = "0x20")]
		public Transform MapPanel;

		// Token: 0x0400E650 RID: 58960
		[Token(Token = "0x400E650")]
		[FieldOffset(Offset = "0x28")]
		public GameObject mushroom;

		// Token: 0x0400E651 RID: 58961
		[Token(Token = "0x400E651")]
		[FieldOffset(Offset = "0x30")]
		public UITexture MapBG;

		// Token: 0x0400E652 RID: 58962
		[Token(Token = "0x400E652")]
		[FieldOffset(Offset = "0x38")]
		public UITexture MapGrid;

		// Token: 0x0400E653 RID: 58963
		[Token(Token = "0x400E653")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BombDangerArea;

		// Token: 0x0400E654 RID: 58964
		[Token(Token = "0x400E654")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BombDangerInstance;

		// Token: 0x0400E655 RID: 58965
		[Token(Token = "0x400E655")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WarningZoneArea;

		// Token: 0x0400E656 RID: 58966
		[Token(Token = "0x400E656")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HotzoneContainer;

		// Token: 0x0400E657 RID: 58967
		[Token(Token = "0x400E657")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HotzoneArea;

		// Token: 0x0400E658 RID: 58968
		[Token(Token = "0x400E658")]
		[FieldOffset(Offset = "0x68")]
		public UISprite GuideToMark;

		// Token: 0x0400E659 RID: 58969
		[Token(Token = "0x400E659")]
		[FieldOffset(Offset = "0x70")]
		public UISprite warningToSafeZone;

		// Token: 0x0400E65A RID: 58970
		[Token(Token = "0x400E65A")]
		[FieldOffset(Offset = "0x78")]
		public Transform warningArrow;

		// Token: 0x0400E65B RID: 58971
		[Token(Token = "0x400E65B")]
		[FieldOffset(Offset = "0x80")]
		public UISprite GuideToSaveZone;

		// Token: 0x0400E65C RID: 58972
		[Token(Token = "0x400E65C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject OBAirtransporter;

		// Token: 0x0400E65D RID: 58973
		[Token(Token = "0x400E65D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject PlayerArrow;

		// Token: 0x0400E65E RID: 58974
		[Token(Token = "0x400E65E")]
		[FieldOffset(Offset = "0x98")]
		public TweenAlpha UavPlayerArrow;

		// Token: 0x0400E65F RID: 58975
		[Token(Token = "0x400E65F")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Arrow;

		// Token: 0x0400E660 RID: 58976
		[Token(Token = "0x400E660")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject TeamMate;

		// Token: 0x0400E661 RID: 58977
		[Token(Token = "0x400E661")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject id;

		// Token: 0x0400E662 RID: 58978
		[Token(Token = "0x400E662")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject direction;

		// Token: 0x0400E663 RID: 58979
		[Token(Token = "0x400E663")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject knockdown;

		// Token: 0x0400E664 RID: 58980
		[Token(Token = "0x400E664")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject dead;

		// Token: 0x0400E665 RID: 58981
		[Token(Token = "0x400E665")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject vehicle;

		// Token: 0x0400E666 RID: 58982
		[Token(Token = "0x400E666")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject TeammatePoints;

		// Token: 0x0400E667 RID: 58983
		[Token(Token = "0x400E667")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite TeammatePoint1;

		// Token: 0x0400E668 RID: 58984
		[Token(Token = "0x400E668")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite TeammatePoint2;

		// Token: 0x0400E669 RID: 58985
		[Token(Token = "0x400E669")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite TeammatePoint3;

		// Token: 0x0400E66A RID: 58986
		[Token(Token = "0x400E66A")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite UavPoint;

		// Token: 0x0400E66B RID: 58987
		[Token(Token = "0x400E66B")]
		[FieldOffset(Offset = "0x100")]
		public UISprite DetectorPoint;

		// Token: 0x0400E66C RID: 58988
		[Token(Token = "0x400E66C")]
		[FieldOffset(Offset = "0x108")]
		public UISprite DetectorCar;

		// Token: 0x0400E66D RID: 58989
		[Token(Token = "0x400E66D")]
		[FieldOffset(Offset = "0x110")]
		public Transform Uav;

		// Token: 0x0400E66E RID: 58990
		[Token(Token = "0x400E66E")]
		[FieldOffset(Offset = "0x118")]
		public UIUAVMapObjectView UAVObjectView;

		// Token: 0x0400E66F RID: 58991
		[Token(Token = "0x400E66F")]
		[FieldOffset(Offset = "0x120")]
		public UISprite UavCircle;

		// Token: 0x0400E670 RID: 58992
		[Token(Token = "0x400E670")]
		[FieldOffset(Offset = "0x128")]
		public TweenScale UavCircleLine;

		// Token: 0x0400E671 RID: 58993
		[Token(Token = "0x400E671")]
		[FieldOffset(Offset = "0x130")]
		public Transform Bounty;

		// Token: 0x0400E672 RID: 58994
		[Token(Token = "0x400E672")]
		[FieldOffset(Offset = "0x138")]
		public UISprite MarkCircle;

		// Token: 0x0400E673 RID: 58995
		[Token(Token = "0x400E673")]
		[FieldOffset(Offset = "0x140")]
		public TweenAlpha MarkerTween;

		// Token: 0x0400E674 RID: 58996
		[Token(Token = "0x400E674")]
		[FieldOffset(Offset = "0x148")]
		public TweenScale MarkCircleLine;

		// Token: 0x0400E675 RID: 58997
		[Token(Token = "0x400E675")]
		[FieldOffset(Offset = "0x150")]
		public UISprite DirectionHint;

		// Token: 0x0400E676 RID: 58998
		[Token(Token = "0x400E676")]
		[FieldOffset(Offset = "0x158")]
		public TweenAlpha DirectionHintTween;

		// Token: 0x0400E677 RID: 58999
		[Token(Token = "0x400E677")]
		[FieldOffset(Offset = "0x160")]
		public Transform Detector;

		// Token: 0x0400E678 RID: 59000
		[Token(Token = "0x400E678")]
		[FieldOffset(Offset = "0x168")]
		public UISprite DetectorCircle;

		// Token: 0x0400E679 RID: 59001
		[Token(Token = "0x400E679")]
		[FieldOffset(Offset = "0x170")]
		public TweenScale DetectorCircleLine;

		// Token: 0x0400E67A RID: 59002
		[Token(Token = "0x400E67A")]
		[FieldOffset(Offset = "0x178")]
		public UISprite AirLine;

		// Token: 0x0400E67B RID: 59003
		[Token(Token = "0x400E67B")]
		[FieldOffset(Offset = "0x180")]
		public UISprite AirLinePointStart;

		// Token: 0x0400E67C RID: 59004
		[Token(Token = "0x400E67C")]
		[FieldOffset(Offset = "0x188")]
		public UISprite AirLinePointEnd;

		// Token: 0x0400E67D RID: 59005
		[Token(Token = "0x400E67D")]
		[FieldOffset(Offset = "0x190")]
		public Transform OBPlayerContainer;

		// Token: 0x0400E67E RID: 59006
		[Token(Token = "0x400E67E")]
		[FieldOffset(Offset = "0x198")]
		public UISprite SpectatorAirDrop;

		// Token: 0x0400E67F RID: 59007
		[Token(Token = "0x400E67F")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject TreasureMark;

		// Token: 0x0400E680 RID: 59008
		[Token(Token = "0x400E680")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject CampFire;

		// Token: 0x0400E681 RID: 59009
		[Token(Token = "0x400E681")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject Carepackage;

		// Token: 0x0400E682 RID: 59010
		[Token(Token = "0x400E682")]
		[FieldOffset(Offset = "0x1B8")]
		public LastVehicleObject LastVehicleUIObject;

		// Token: 0x0400E683 RID: 59011
		[Token(Token = "0x400E683")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject MapMarks;

		// Token: 0x0400E684 RID: 59012
		[Token(Token = "0x400E684")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject MapMark;

		// Token: 0x0400E685 RID: 59013
		[Token(Token = "0x400E685")]
		[FieldOffset(Offset = "0x1D0")]
		public UISprite Mark;

		// Token: 0x0400E686 RID: 59014
		[Token(Token = "0x400E686")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject MapMark2;

		// Token: 0x0400E687 RID: 59015
		[Token(Token = "0x400E687")]
		[FieldOffset(Offset = "0x1E0")]
		public UISprite Mark2;

		// Token: 0x0400E688 RID: 59016
		[Token(Token = "0x400E688")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject MapMark3;

		// Token: 0x0400E689 RID: 59017
		[Token(Token = "0x400E689")]
		[FieldOffset(Offset = "0x1F0")]
		public UISprite Mark3;

		// Token: 0x0400E68A RID: 59018
		[Token(Token = "0x400E68A")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject MapMark4;

		// Token: 0x0400E68B RID: 59019
		[Token(Token = "0x400E68B")]
		[FieldOffset(Offset = "0x200")]
		public UISprite Mark4;

		// Token: 0x0400E68C RID: 59020
		[Token(Token = "0x400E68C")]
		[FieldOffset(Offset = "0x208")]
		public GameObject Zombie;

		// Token: 0x0400E68D RID: 59021
		[Token(Token = "0x400E68D")]
		[FieldOffset(Offset = "0x210")]
		public GameObject EnermyPoint;

		// Token: 0x0400E68E RID: 59022
		[Token(Token = "0x400E68E")]
		[FieldOffset(Offset = "0x218")]
		public GameObject TeleportDoor;

		// Token: 0x0400E68F RID: 59023
		[Token(Token = "0x400E68F")]
		[FieldOffset(Offset = "0x220")]
		public GameObject MaxHypePlayerPoint;

		// Token: 0x0400E690 RID: 59024
		[Token(Token = "0x400E690")]
		[FieldOffset(Offset = "0x228")]
		public GameObject AirDropNext;

		// Token: 0x0400E691 RID: 59025
		[Token(Token = "0x400E691")]
		[FieldOffset(Offset = "0x230")]
		public GameObject ToxicZoneArea;

		// Token: 0x0400E692 RID: 59026
		[Token(Token = "0x400E692")]
		[FieldOffset(Offset = "0x238")]
		public GameObject ToxicZoneInstance;

		// Token: 0x0400E693 RID: 59027
		[Token(Token = "0x400E693")]
		[FieldOffset(Offset = "0x240")]
		public GameObject csZone;

		// Token: 0x0400E694 RID: 59028
		[Token(Token = "0x400E694")]
		[FieldOffset(Offset = "0x248")]
		public GameObject gamezone;

		// Token: 0x0400E695 RID: 59029
		[Token(Token = "0x400E695")]
		[FieldOffset(Offset = "0x250")]
		public GameObject CandyZoneIcon;

		// Token: 0x0400E696 RID: 59030
		[Token(Token = "0x400E696")]
		[FieldOffset(Offset = "0x258")]
		public GameObject Pumpkin;

		// Token: 0x0400E697 RID: 59031
		[Token(Token = "0x400E697")]
		[FieldOffset(Offset = "0x260")]
		public PlayerPumpkinInfo PlayerPumpkin;

		// Token: 0x0400E698 RID: 59032
		[Token(Token = "0x400E698")]
		[FieldOffset(Offset = "0x268")]
		public GameObject GeneratedBuff;

		// Token: 0x0400E699 RID: 59033
		[Token(Token = "0x400E699")]
		[FieldOffset(Offset = "0x270")]
		public GameObject ItemGenerator;

		// Token: 0x0400E69A RID: 59034
		[Token(Token = "0x400E69A")]
		[FieldOffset(Offset = "0x278")]
		public GameObject bombZone;

		// Token: 0x0400E69B RID: 59035
		[Token(Token = "0x400E69B")]
		[FieldOffset(Offset = "0x280")]
		public GameObject bombZoneTemplate;

		// Token: 0x0400E69C RID: 59036
		[Token(Token = "0x400E69C")]
		[FieldOffset(Offset = "0x288")]
		public UISprite BombPickup;

		// Token: 0x0400E69D RID: 59037
		[Token(Token = "0x400E69D")]
		[FieldOffset(Offset = "0x290")]
		public UISprite zeppelin;

		// Token: 0x0400E69E RID: 59038
		[Token(Token = "0x400E69E")]
		[FieldOffset(Offset = "0x298")]
		public UISprite zeppelinDestination;

		// Token: 0x0400E69F RID: 59039
		[Token(Token = "0x400E69F")]
		[FieldOffset(Offset = "0x2A0")]
		public UISprite zeppelinDirection;

		// Token: 0x0400E6A0 RID: 59040
		[Token(Token = "0x400E6A0")]
		[FieldOffset(Offset = "0x2A8")]
		public UISprite ReaperPlayer;

		// Token: 0x0400E6A1 RID: 59041
		[Token(Token = "0x400E6A1")]
		[FieldOffset(Offset = "0x2B0")]
		public UISprite DetectiveMarkPoint;

		// Token: 0x0400E6A2 RID: 59042
		[Token(Token = "0x400E6A2")]
		[FieldOffset(Offset = "0x2B8")]
		public UISprite EscortVehicle;

		// Token: 0x0400E6A3 RID: 59043
		[Token(Token = "0x400E6A3")]
		[FieldOffset(Offset = "0x2C0")]
		public GameObject DetectiveEffectObj;

		// Token: 0x0400E6A4 RID: 59044
		[Token(Token = "0x400E6A4")]
		[FieldOffset(Offset = "0x2C8")]
		public GameObject DetectiveEffect;

		// Token: 0x0400E6A5 RID: 59045
		[Token(Token = "0x400E6A5")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject DeliveryMarkEnermyPoint;

		// Token: 0x0400E6A6 RID: 59046
		[Token(Token = "0x400E6A6")]
		[FieldOffset(Offset = "0x2D8")]
		public GameObject RevivePointContainer;

		// Token: 0x0400E6A7 RID: 59047
		[Token(Token = "0x400E6A7")]
		[FieldOffset(Offset = "0x2E0")]
		public GameObject RevivePointIcon;

		// Token: 0x0400E6A8 RID: 59048
		[Token(Token = "0x400E6A8")]
		[FieldOffset(Offset = "0x2E8")]
		public GameObject IngameShopPointContainer;

		// Token: 0x0400E6A9 RID: 59049
		[Token(Token = "0x400E6A9")]
		[FieldOffset(Offset = "0x2F0")]
		public GameObject IngameShopPointIcon;

		// Token: 0x0400E6AA RID: 59050
		[Token(Token = "0x400E6AA")]
		[FieldOffset(Offset = "0x2F8")]
		public GameObject BountyContract;

		// Token: 0x0400E6AB RID: 59051
		[Token(Token = "0x400E6AB")]
		[FieldOffset(Offset = "0x300")]
		public UISprite WereWolvesBody;

		// Token: 0x0400E6AC RID: 59052
		[Token(Token = "0x400E6AC")]
		[FieldOffset(Offset = "0x308")]
		public UILabel WereWolvesBodyName;

		// Token: 0x0400E6AD RID: 59053
		[Token(Token = "0x400E6AD")]
		[FieldOffset(Offset = "0x310")]
		public GameObject TaskPoint;

		// Token: 0x0400E6AE RID: 59054
		[Token(Token = "0x400E6AE")]
		[FieldOffset(Offset = "0x318")]
		public GameObject randomCenter;

		// Token: 0x0400E6AF RID: 59055
		[Token(Token = "0x400E6AF")]
		[FieldOffset(Offset = "0x320")]
		public GameObject EmergencyTaskPoint;
	}
}
