// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datadog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Datadog dashboard resource. This can be used to create and manage Datadog dashboards.
//
// > **Note:** This resource uses the new [Dashboard API](https://docs.datadoghq.com/api/v1/dashboards/) which adds new features like better validation and support for the [Group widget](https://docs.datadoghq.com/dashboards/widgets/group/). Additionally, this resource unifies `TimeBoard` and `ScreenBoard` resources to allow you to manage all of your dashboards using a single format.
//
// ## Example Usage
// ### Create A New Datadog Dashboard - Ordered Layout
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := datadog.NewDashboard(ctx, "orderedDashboard", &datadog.DashboardArgs{
// 			Description: pulumi.String("Created using the Datadog provider in Terraform"),
// 			IsReadOnly:  pulumi.Bool(true),
// 			LayoutType:  pulumi.String("ordered"),
// 			TemplateVariables: datadog.DashboardTemplateVariableArray{
// 				&datadog.DashboardTemplateVariableArgs{
// 					Default: pulumi.String("aws"),
// 					Name:    pulumi.String("var_1"),
// 					Prefix:  pulumi.String("host"),
// 				},
// 				&datadog.DashboardTemplateVariableArgs{
// 					Default: pulumi.String("autoscaling"),
// 					Name:    pulumi.String("var_2"),
// 					Prefix:  pulumi.String("service_name"),
// 				},
// 			},
// 			TemplateVariablePresets: datadog.DashboardTemplateVariablePresetArray{
// 				&datadog.DashboardTemplateVariablePresetArgs{
// 					Name: pulumi.String("preset_1"),
// 					TemplateVariables: datadog.DashboardTemplateVariablePresetTemplateVariableArray{
// 						&datadog.DashboardTemplateVariablePresetTemplateVariableArgs{
// 							Name:  pulumi.String("var_1"),
// 							Value: pulumi.String("host.dc"),
// 						},
// 						&datadog.DashboardTemplateVariablePresetTemplateVariableArgs{
// 							Name:  pulumi.String("var_2"),
// 							Value: pulumi.String("my_service"),
// 						},
// 					},
// 				},
// 			},
// 			Title: pulumi.String("Ordered Layout Dashboard"),
// 			Widgets: datadog.DashboardWidgetArray{
// 				&datadog.DashboardWidgetArgs{
// 					AlertGraphDefinition: &datadog.DashboardWidgetAlertGraphDefinitionArgs{
// 						AlertId: pulumi.String("895605"),
// 						Time: &datadog.DashboardWidgetAlertGraphDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title:   pulumi.String("Widget Title"),
// 						VizType: pulumi.String("timeseries"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					AlertValueDefinition: &datadog.DashboardWidgetAlertValueDefinitionArgs{
// 						AlertId:   pulumi.String("895605"),
// 						Precision: pulumi.Int(3),
// 						TextAlign: pulumi.String("center"),
// 						Title:     pulumi.String("Widget Title"),
// 						Unit:      pulumi.String("b"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					AlertValueDefinition: &datadog.DashboardWidgetAlertValueDefinitionArgs{
// 						AlertId:   pulumi.String("895605"),
// 						Precision: pulumi.Int(3),
// 						TextAlign: pulumi.String("center"),
// 						Title:     pulumi.String("Widget Title"),
// 						Unit:      pulumi.String("b"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					ChangeDefinition: &datadog.DashboardWidgetChangeDefinitionArgs{
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"changeType":   pulumi.String("absolute"),
// 								"compareTo":    pulumi.String("week_before"),
// 								"increaseGood": pulumi.Bool(true),
// 								"orderBy":      pulumi.String("name"),
// 								"orderDir":     pulumi.String("desc"),
// 								"q":            pulumi.String("avg:system.load.1{env:staging} by {account}"),
// 								"showPresent":  pulumi.Bool(true),
// 							},
// 						},
// 						Time: &datadog.DashboardWidgetChangeDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					DistributionDefinition: &datadog.DashboardWidgetDistributionDefinitionArgs{
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"q": pulumi.String("avg:system.load.1{env:staging} by {account}"),
// 								"style": pulumi.StringMap{
// 									"palette": pulumi.String("warm"),
// 								},
// 							},
// 						},
// 						Time: &datadog.DashboardWidgetDistributionDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					CheckStatusDefinition: &datadog.DashboardWidgetCheckStatusDefinitionArgs{
// 						Check: pulumi.String("aws.ecs.agent_connected"),
// 						GroupBy: pulumi.StringArray{
// 							pulumi.String("account"),
// 							pulumi.String("cluster"),
// 						},
// 						Grouping: pulumi.String("cluster"),
// 						Tags: pulumi.StringArray{
// 							pulumi.String("account:demo"),
// 							pulumi.String("cluster:awseb-ruthebdog-env-8-dn3m6u3gvk"),
// 						},
// 						Time: &datadog.DashboardWidgetCheckStatusDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					HeatmapDefinition: &datadog.DashboardWidgetHeatmapDefinitionArgs{
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"q": pulumi.String("avg:system.load.1{env:staging} by {account}"),
// 								"style": pulumi.StringMap{
// 									"palette": pulumi.String("warm"),
// 								},
// 							},
// 						},
// 						Time: &datadog.DashboardWidgetHeatmapDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 						Yaxis: &datadog.DashboardWidgetHeatmapDefinitionYaxisArgs{
// 							IncludeZero: pulumi.Bool(true),
// 							Max:         pulumi.String("2"),
// 							Min:         pulumi.String("1"),
// 							Scale:       pulumi.String("sqrt"),
// 						},
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					HostmapDefinition: &datadog.DashboardWidgetHostmapDefinitionArgs{
// 						Group: pulumi.StringArray{
// 							pulumi.String("host"),
// 							pulumi.String("region"),
// 						},
// 						NoGroupHosts:  pulumi.Bool(true),
// 						NoMetricHosts: pulumi.Bool(true),
// 						NodeType:      pulumi.String("container"),
// 						Request: &datadog.DashboardWidgetHostmapDefinitionRequestArgs{
// 							Fill: pulumi.StringMapArray{
// 								pulumi.StringMap{
// 									"q": pulumi.String("avg:system.load.1{*} by {host}"),
// 								},
// 							},
// 							Size: pulumi.StringMapArray{
// 								pulumi.StringMap{
// 									"q": pulumi.String("avg:memcache.uptime{*} by {host}"),
// 								},
// 							},
// 						},
// 						Scope: pulumi.StringArray{
// 							pulumi.String("region:us-east-1"),
// 							pulumi.String("aws_account:727006795293"),
// 						},
// 						Style: &datadog.DashboardWidgetHostmapDefinitionStyleArgs{
// 							FillMax:     pulumi.String("20"),
// 							FillMin:     pulumi.String("10"),
// 							Palette:     pulumi.String("yellow_to_green"),
// 							PaletteFlip: pulumi.Bool(true),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					NoteDefinition: &datadog.DashboardWidgetNoteDefinitionArgs{
// 						BackgroundColor: pulumi.String("pink"),
// 						Content:         pulumi.String("note text"),
// 						FontSize:        pulumi.String("14"),
// 						ShowTick:        pulumi.Bool(true),
// 						TextAlign:       pulumi.String("center"),
// 						TickEdge:        pulumi.String("left"),
// 						TickPos:         pulumi.String(fmt.Sprintf("%v%v", "50", "%")),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					QueryValueDefinition: &datadog.DashboardWidgetQueryValueDefinitionArgs{
// 						Autoscale:  pulumi.Bool(true),
// 						CustomUnit: pulumi.String("xx"),
// 						Precision:  pulumi.Int(4),
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"aggregator": pulumi.String("sum"),
// 								"conditionalFormats": pulumi.StringMapArray{
// 									pulumi.StringMap{
// 										"comparator": pulumi.String("<"),
// 										"palette":    pulumi.String("white_on_green"),
// 										"value":      pulumi.String("2"),
// 									},
// 									pulumi.StringMap{
// 										"comparator": pulumi.String(">"),
// 										"palette":    pulumi.String("white_on_red"),
// 										"value":      pulumi.String("2.2"),
// 									},
// 								},
// 								"q": pulumi.String("avg:system.load.1{env:staging} by {account}"),
// 							},
// 						},
// 						TextAlign: pulumi.String("right"),
// 						Time: &datadog.DashboardWidgetQueryValueDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					QueryTableDefinition: &datadog.DashboardWidgetQueryTableDefinitionArgs{
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"aggregator": pulumi.String("sum"),
// 								"conditionalFormats": pulumi.StringMapArray{
// 									pulumi.StringMap{
// 										"comparator": pulumi.String("<"),
// 										"palette":    pulumi.String("white_on_green"),
// 										"value":      pulumi.String("2"),
// 									},
// 									pulumi.StringMap{
// 										"comparator": pulumi.String(">"),
// 										"palette":    pulumi.String("white_on_red"),
// 										"value":      pulumi.String("2.2"),
// 									},
// 								},
// 								"limit": pulumi.String("10"),
// 								"q":     pulumi.String("avg:system.load.1{env:staging} by {account}"),
// 							},
// 						},
// 						Time: &datadog.DashboardWidgetQueryTableDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					ScatterplotDefinition: &datadog.DashboardWidgetScatterplotDefinitionArgs{
// 						ColorByGroups: pulumi.StringArray{
// 							pulumi.String("account"),
// 							pulumi.String("apm-role-group"),
// 						},
// 						Request: &datadog.DashboardWidgetScatterplotDefinitionRequestArgs{
// 							X: pulumi.StringMapArray{
// 								pulumi.StringMap{
// 									"aggregator": pulumi.String("max"),
// 									"q":          pulumi.String("avg:system.cpu.user{*} by {service, account}"),
// 								},
// 							},
// 							Y: pulumi.StringMapArray{
// 								pulumi.StringMap{
// 									"aggregator": pulumi.String("min"),
// 									"q":          pulumi.String("avg:system.mem.used{*} by {service, account}"),
// 								},
// 							},
// 						},
// 						Time: &datadog.DashboardWidgetScatterplotDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 						Xaxis: &datadog.DashboardWidgetScatterplotDefinitionXaxisArgs{
// 							IncludeZero: pulumi.Bool(true),
// 							Label:       pulumi.String("x"),
// 							Max:         pulumi.String("2000"),
// 							Min:         pulumi.String("1"),
// 							Scale:       pulumi.String("pow"),
// 						},
// 						Yaxis: &datadog.DashboardWidgetScatterplotDefinitionYaxisArgs{
// 							IncludeZero: pulumi.Bool(false),
// 							Label:       pulumi.String("y"),
// 							Max:         pulumi.String("2222"),
// 							Min:         pulumi.String("5"),
// 							Scale:       pulumi.String("log"),
// 						},
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(43),
// 						Width:  pulumi.Float64(32),
// 						X:      pulumi.Float64(5),
// 						Y:      pulumi.Float64(5),
// 					},
// 					ServicemapDefinition: &datadog.DashboardWidgetServicemapDefinitionArgs{
// 						Filters: pulumi.StringArray{
// 							pulumi.String("env:prod"),
// 							pulumi.String("datacenter:us1.prod.dog"),
// 						},
// 						Service:    pulumi.String("master-db"),
// 						Title:      pulumi.String("env: prod, datacenter:us1.prod.dog, service: master-db"),
// 						TitleAlign: pulumi.String("left"),
// 						TitleSize:  pulumi.String("16"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					TimeseriesDefinition: &datadog.DashboardWidgetTimeseriesDefinitionArgs{
// 						Event: pulumi.StringMapArray{
// 							pulumi.StringMap{
// 								"q": pulumi.String("sources:test tags:1"),
// 							},
// 							pulumi.StringMap{
// 								"q": pulumi.String("sources:test tags:2"),
// 							},
// 						},
// 						LegendSize: pulumi.String("2"),
// 						Marker: pulumi.StringMapArray{
// 							pulumi.StringMap{
// 								"displayType": pulumi.String("error dashed"),
// 								"label":       pulumi.String(" z=6 "),
// 								"value":       pulumi.String("y = 4"),
// 							},
// 							pulumi.StringMap{
// 								"displayType": pulumi.String("ok solid"),
// 								"label":       pulumi.String(" x=8 "),
// 								"value":       pulumi.String("10 < y < 999"),
// 							},
// 						},
// 						Request: pulumi.Array{
// 							pulumi.Map{
// 								"displayType": pulumi.String("line"),
// 								"metadata": pulumi.StringMapArray{
// 									pulumi.StringMap{
// 										"aliasName":  pulumi.String("Alpha"),
// 										"expression": pulumi.String("avg:system.cpu.user{app:general} by {env}"),
// 									},
// 								},
// 								"q": pulumi.String("avg:system.cpu.user{app:general} by {env}"),
// 								"style": pulumi.StringMap{
// 									"lineType":  pulumi.String("dashed"),
// 									"lineWidth": pulumi.String("thin"),
// 									"palette":   pulumi.String("warm"),
// 								},
// 							},
// 							pulumi.Map{
// 								"displayType": pulumi.String("area"),
// 								"logQuery": pulumi.Map{
// 									"compute": pulumi.Map{
// 										"aggregation": pulumi.String("avg"),
// 										"facet":       pulumi.String("@duration"),
// 										"interval":    pulumi.Float64(5000),
// 									},
// 									"groupBy": pulumi.MapArray{
// 										pulumi.Map{
// 											"facet": pulumi.String("host"),
// 											"limit": pulumi.Float64(10),
// 											"sort": pulumi.StringMap{
// 												"aggregation": pulumi.String("avg"),
// 												"facet":       pulumi.String("@duration"),
// 												"order":       pulumi.String("desc"),
// 											},
// 										},
// 									},
// 									"index": pulumi.String("mcnulty"),
// 									"search": pulumi.StringMap{
// 										"query": pulumi.String("status:info"),
// 									},
// 								},
// 							},
// 							pulumi.Map{
// 								"apmQuery": pulumi.Map{
// 									"compute": pulumi.Map{
// 										"aggregation": pulumi.String("avg"),
// 										"facet":       pulumi.String("@duration"),
// 										"interval":    pulumi.Float64(5000),
// 									},
// 									"groupBy": pulumi.MapArray{
// 										pulumi.Map{
// 											"facet": pulumi.String("resource_name"),
// 											"limit": pulumi.Float64(50),
// 											"sort": pulumi.StringMap{
// 												"aggregation": pulumi.String("avg"),
// 												"facet":       pulumi.String("@string_query.interval"),
// 												"order":       pulumi.String("desc"),
// 											},
// 										},
// 									},
// 									"index": pulumi.String("apm-search"),
// 									"search": pulumi.StringMap{
// 										"query": pulumi.String("type:web"),
// 									},
// 								},
// 								"displayType": pulumi.String("bars"),
// 							},
// 							pulumi.Map{
// 								"displayType": pulumi.String("area"),
// 								"processQuery": pulumi.Map{
// 									"filterBy": pulumi.StringArray{
// 										pulumi.String("active"),
// 									},
// 									"limit":    pulumi.Float64(50),
// 									"metric":   pulumi.String("process.stat.cpu.total_pct"),
// 									"searchBy": pulumi.String("error"),
// 								},
// 							},
// 						},
// 						ShowLegend: pulumi.Bool(true),
// 						Time: &datadog.DashboardWidgetTimeseriesDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title: pulumi.String("Widget Title"),
// 						Yaxis: &datadog.DashboardWidgetTimeseriesDefinitionYaxisArgs{
// 							IncludeZero: pulumi.Bool(false),
// 							Max:         pulumi.String("100"),
// 							Scale:       pulumi.String("log"),
// 						},
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					ToplistDefinition: &datadog.DashboardWidgetToplistDefinitionArgs{
// 						Request: pulumi.MapArray{
// 							pulumi.Map{
// 								"conditionalFormats": pulumi.StringMapArray{
// 									pulumi.StringMap{
// 										"comparator": pulumi.String("<"),
// 										"palette":    pulumi.String("white_on_green"),
// 										"value":      pulumi.String("2"),
// 									},
// 									pulumi.StringMap{
// 										"comparator": pulumi.String(">"),
// 										"palette":    pulumi.String("white_on_red"),
// 										"value":      pulumi.String("2.2"),
// 									},
// 								},
// 								"q": pulumi.String("avg:system.cpu.user{app:general} by {env}"),
// 							},
// 						},
// 						Title: pulumi.String("Widget Title"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					GroupDefinition: &datadog.DashboardWidgetGroupDefinitionArgs{
// 						LayoutType: pulumi.String("ordered"),
// 						Title:      pulumi.String("Group Widget"),
// 						Widget: pulumi.Array{
// 							pulumi.MapMap{
// 								"noteDefinition": pulumi.Map{
// 									"backgroundColor": pulumi.String("pink"),
// 									"content":         pulumi.String("cluster note widget"),
// 									"fontSize":        pulumi.String("14"),
// 									"showTick":        pulumi.Bool(true),
// 									"textAlign":       pulumi.String("center"),
// 									"tickEdge":        pulumi.String("left"),
// 									"tickPos":         pulumi.String(fmt.Sprintf("%v%v", "50", "%")),
// 								},
// 							},
// 							pulumi.MapMap{
// 								"alertGraphDefinition": pulumi.Map{
// 									"alertId": pulumi.String("123"),
// 									"time": pulumi.StringMap{
// 										"liveSpan": pulumi.String("1h"),
// 									},
// 									"title":   pulumi.String("Alert Graph"),
// 									"vizType": pulumi.String("toplist"),
// 								},
// 							},
// 						},
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					ServiceLevelObjectiveDefinition: &datadog.DashboardWidgetServiceLevelObjectiveDefinitionArgs{
// 						ShowErrorBudget: pulumi.Bool(true),
// 						SloId:           pulumi.String("56789"),
// 						TimeWindows: pulumi.StringArray{
// 							pulumi.String("7d"),
// 							pulumi.String("previous_week"),
// 						},
// 						Title:    pulumi.String("Widget Title"),
// 						ViewMode: pulumi.String("overall"),
// 						ViewType: pulumi.String("detail"),
// 					},
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Create A New Datadog Dashboard - Free Layout
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-datadog/sdk/v2/go/datadog"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := datadog.NewDashboard(ctx, "freeDashboard", &datadog.DashboardArgs{
// 			Description: pulumi.String("Created using the Datadog provider in Terraform"),
// 			IsReadOnly:  pulumi.Bool(false),
// 			LayoutType:  pulumi.String("free"),
// 			TemplateVariables: datadog.DashboardTemplateVariableArray{
// 				&datadog.DashboardTemplateVariableArgs{
// 					Default: pulumi.String("aws"),
// 					Name:    pulumi.String("var_1"),
// 					Prefix:  pulumi.String("host"),
// 				},
// 				&datadog.DashboardTemplateVariableArgs{
// 					Default: pulumi.String("autoscaling"),
// 					Name:    pulumi.String("var_2"),
// 					Prefix:  pulumi.String("service_name"),
// 				},
// 			},
// 			TemplateVariablePresets: datadog.DashboardTemplateVariablePresetArray{
// 				&datadog.DashboardTemplateVariablePresetArgs{
// 					Name: pulumi.String("preset_1"),
// 					TemplateVariables: datadog.DashboardTemplateVariablePresetTemplateVariableArray{
// 						&datadog.DashboardTemplateVariablePresetTemplateVariableArgs{
// 							Name:  pulumi.String("var_1"),
// 							Value: pulumi.String("host.dc"),
// 						},
// 						&datadog.DashboardTemplateVariablePresetTemplateVariableArgs{
// 							Name:  pulumi.String("var_2"),
// 							Value: pulumi.String("my_service"),
// 						},
// 					},
// 				},
// 			},
// 			Title: pulumi.String("Free Layout Dashboard"),
// 			Widgets: datadog.DashboardWidgetArray{
// 				&datadog.DashboardWidgetArgs{
// 					EventStreamDefinition: &datadog.DashboardWidgetEventStreamDefinitionArgs{
// 						EventSize: pulumi.String("l"),
// 						Query:     pulumi.String("*"),
// 						Time: &datadog.DashboardWidgetEventStreamDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title:      pulumi.String("Widget Title"),
// 						TitleAlign: pulumi.String("left"),
// 						TitleSize:  pulumi.String("16"),
// 					},
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(43),
// 						Width:  pulumi.Float64(32),
// 						X:      pulumi.Float64(5),
// 						Y:      pulumi.Float64(5),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					EventTimelineDefinition: &datadog.DashboardWidgetEventTimelineDefinitionArgs{
// 						Query: pulumi.String("*"),
// 						Time: &datadog.DashboardWidgetEventTimelineDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title:      pulumi.String("Widget Title"),
// 						TitleAlign: pulumi.String("left"),
// 						TitleSize:  pulumi.String("16"),
// 					},
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(9),
// 						Width:  pulumi.Float64(65),
// 						X:      pulumi.Float64(42),
// 						Y:      pulumi.Float64(73),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					FreeTextDefinition: &datadog.DashboardWidgetFreeTextDefinitionArgs{
// 						Color:     pulumi.String("#d00"),
// 						FontSize:  pulumi.String("88"),
// 						Text:      pulumi.String("free text content"),
// 						TextAlign: pulumi.String("left"),
// 					},
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(20),
// 						Width:  pulumi.Float64(30),
// 						X:      pulumi.Float64(42),
// 						Y:      pulumi.Float64(5),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					IframeDefinition: &datadog.DashboardWidgetIframeDefinitionArgs{
// 						Url: pulumi.String("http://google.com"),
// 					},
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(46),
// 						Width:  pulumi.Float64(39),
// 						X:      pulumi.Float64(111),
// 						Y:      pulumi.Float64(8),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					ImageDefinition: &datadog.DashboardWidgetImageDefinitionArgs{
// 						Margin: pulumi.String("small"),
// 						Sizing: pulumi.String("fit"),
// 						Url:    pulumi.String("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?auto=compress&cs=tinysrgb&h=350"),
// 					},
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(20),
// 						Width:  pulumi.Float64(30),
// 						X:      pulumi.Float64(77),
// 						Y:      pulumi.Float64(7),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(36),
// 						Width:  pulumi.Float64(32),
// 						X:      pulumi.Float64(5),
// 						Y:      pulumi.Float64(51),
// 					},
// 					LogStreamDefinition: &datadog.DashboardWidgetLogStreamDefinitionArgs{
// 						Columns: pulumi.StringArray{
// 							pulumi.String("core_host"),
// 							pulumi.String("core_service"),
// 							pulumi.String("tag_source"),
// 						},
// 						Indexes: pulumi.StringArray{
// 							pulumi.String("main"),
// 						},
// 						MessageDisplay:    pulumi.String("expanded-md"),
// 						Query:             pulumi.String("error"),
// 						ShowDateColumn:    pulumi.Bool(true),
// 						ShowMessageColumn: pulumi.Bool(true),
// 						Sort: &datadog.DashboardWidgetLogStreamDefinitionSortArgs{
// 							Column: pulumi.String("time"),
// 							Order:  pulumi.String("desc"),
// 						},
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(40),
// 						Width:  pulumi.Float64(30),
// 						X:      pulumi.Float64(112),
// 						Y:      pulumi.Float64(55),
// 					},
// 					ManageStatusDefinition: &datadog.DashboardWidgetManageStatusDefinitionArgs{
// 						ColorPreference:   pulumi.String("text"),
// 						DisplayFormat:     pulumi.String("countsAndList"),
// 						HideZeroCounts:    pulumi.Bool(true),
// 						Query:             pulumi.String("type:metric"),
// 						ShowLastTriggered: pulumi.Bool(false),
// 						Sort:              pulumi.String("status,asc"),
// 						SummaryType:       pulumi.String("monitors"),
// 						Title:             pulumi.String("Widget Title"),
// 						TitleAlign:        pulumi.String("left"),
// 						TitleSize:         pulumi.String("16"),
// 					},
// 				},
// 				&datadog.DashboardWidgetArgs{
// 					Layout: &datadog.DashboardWidgetLayoutArgs{
// 						Height: pulumi.Float64(38),
// 						Width:  pulumi.Float64(67),
// 						X:      pulumi.Float64(40),
// 						Y:      pulumi.Float64(28),
// 					},
// 					TraceServiceDefinition: &datadog.DashboardWidgetTraceServiceDefinitionArgs{
// 						DisplayFormat:    pulumi.String("three_column"),
// 						Env:              pulumi.String("datad0g.com"),
// 						Service:          pulumi.String("alerting-cassandra"),
// 						ShowBreakdown:    pulumi.Bool(true),
// 						ShowDistribution: pulumi.Bool(true),
// 						ShowErrors:       pulumi.Bool(true),
// 						ShowHits:         pulumi.Bool(true),
// 						ShowLatency:      pulumi.Bool(false),
// 						ShowResourceList: pulumi.Bool(false),
// 						SizeFormat:       pulumi.String("large"),
// 						SpanName:         pulumi.String("cassandra.query"),
// 						Time: &datadog.DashboardWidgetTraceServiceDefinitionTimeArgs{
// 							LiveSpan: pulumi.String("1h"),
// 						},
// 						Title:      pulumi.String("alerting-cassandra #env:datad0g.com"),
// 						TitleAlign: pulumi.String("center"),
// 						TitleSize:  pulumi.String("13"),
// 					},
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Dashboard struct {
	pulumi.CustomResourceState

	// The list of dashboard lists this dashboard belongs to.
	DashboardLists pulumi.IntArrayOutput `pulumi:"dashboardLists"`
	// The list of dashboard lists this dashboard should be removed from. Internal only.
	DashboardListsRemoveds pulumi.IntArrayOutput `pulumi:"dashboardListsRemoveds"`
	// The description of the dashboard.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrOutput `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringOutput `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayOutput `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayOutput `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayOutput `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title pulumi.StringOutput `pulumi:"title"`
	// The URL of the dashboard.
	Url pulumi.StringOutput `pulumi:"url"`
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayOutput `pulumi:"widgets"`
}

// NewDashboard registers a new resource with the given unique name, arguments, and options.
func NewDashboard(ctx *pulumi.Context,
	name string, args *DashboardArgs, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	if args == nil || args.LayoutType == nil {
		return nil, errors.New("missing required argument 'LayoutType'")
	}
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil || args.Widgets == nil {
		return nil, errors.New("missing required argument 'Widgets'")
	}
	if args == nil {
		args = &DashboardArgs{}
	}
	var resource Dashboard
	err := ctx.RegisterResource("datadog:index/dashboard:Dashboard", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDashboard gets an existing Dashboard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDashboard(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DashboardState, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	var resource Dashboard
	err := ctx.ReadResource("datadog:index/dashboard:Dashboard", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Dashboard resources.
type dashboardState struct {
	// The list of dashboard lists this dashboard belongs to.
	DashboardLists []int `pulumi:"dashboardLists"`
	// The list of dashboard lists this dashboard should be removed from. Internal only.
	DashboardListsRemoveds []int `pulumi:"dashboardListsRemoveds"`
	// The description of the dashboard.
	Description *string `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly *bool `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType *string `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists []string `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets []DashboardTemplateVariablePreset `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables []DashboardTemplateVariable `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title *string `pulumi:"title"`
	// The URL of the dashboard.
	Url *string `pulumi:"url"`
	// The list of widgets to display on the dashboard.
	Widgets []DashboardWidget `pulumi:"widgets"`
}

type DashboardState struct {
	// The list of dashboard lists this dashboard belongs to.
	DashboardLists pulumi.IntArrayInput
	// The list of dashboard lists this dashboard should be removed from. Internal only.
	DashboardListsRemoveds pulumi.IntArrayInput
	// The description of the dashboard.
	Description pulumi.StringPtrInput
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrInput
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringPtrInput
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayInput
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayInput
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayInput
	// The title of the dashboard.
	Title pulumi.StringPtrInput
	// The URL of the dashboard.
	Url pulumi.StringPtrInput
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayInput
}

func (DashboardState) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardState)(nil)).Elem()
}

type dashboardArgs struct {
	// The list of dashboard lists this dashboard belongs to.
	DashboardLists []int `pulumi:"dashboardLists"`
	// The description of the dashboard.
	Description *string `pulumi:"description"`
	// Whether this dashboard is read-only.
	IsReadOnly *bool `pulumi:"isReadOnly"`
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType string `pulumi:"layoutType"`
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists []string `pulumi:"notifyLists"`
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets []DashboardTemplateVariablePreset `pulumi:"templateVariablePresets"`
	// The list of template variables for this dashboard.
	TemplateVariables []DashboardTemplateVariable `pulumi:"templateVariables"`
	// The title of the dashboard.
	Title string `pulumi:"title"`
	// The URL of the dashboard.
	Url *string `pulumi:"url"`
	// The list of widgets to display on the dashboard.
	Widgets []DashboardWidget `pulumi:"widgets"`
}

// The set of arguments for constructing a Dashboard resource.
type DashboardArgs struct {
	// The list of dashboard lists this dashboard belongs to.
	DashboardLists pulumi.IntArrayInput
	// The description of the dashboard.
	Description pulumi.StringPtrInput
	// Whether this dashboard is read-only.
	IsReadOnly pulumi.BoolPtrInput
	// The layout type of the dashboard, either 'free' or 'ordered'.
	LayoutType pulumi.StringInput
	// The list of handles of users to notify when changes are made to this dashboard.
	NotifyLists pulumi.StringArrayInput
	// The list of selectable template variable presets for this dashboard.
	TemplateVariablePresets DashboardTemplateVariablePresetArrayInput
	// The list of template variables for this dashboard.
	TemplateVariables DashboardTemplateVariableArrayInput
	// The title of the dashboard.
	Title pulumi.StringInput
	// The URL of the dashboard.
	Url pulumi.StringPtrInput
	// The list of widgets to display on the dashboard.
	Widgets DashboardWidgetArrayInput
}

func (DashboardArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardArgs)(nil)).Elem()
}
